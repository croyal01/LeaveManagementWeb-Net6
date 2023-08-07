using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
	public class LeaveAllocationRepository : IGenericRepository<LeaveAllocation>, ILeaveAllocationRepository
	{
		private readonly UserManager<Employee> userManager;
		private readonly ILeaveTypeRepository leaveTypeRepository;
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;
		public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
		{
			this.context = context;
			this.userManager = userManager;
			this.leaveTypeRepository = leaveTypeRepository;
			this.mapper = mapper;
		}

		public async Task LeaveAllocation(long leaveTypeId)
		{

			//var employees = await userManager.GetUsersInRoleAsync(Roles.User);
			var employees = await userManager.GetUsersInRoleAsync(Roles.Administrator);
			var period = DateTime.Now.Year;
			var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
			var allocations = new List<LeaveAllocation>();

			foreach (var employee in employees)
			{
				if (await AllocationExists(employee.Id, leaveTypeId, period))
					continue;

				allocations.Add(new LeaveAllocation
				{
					EmployeeId = employee.Id,
					LeaveTypeId = leaveTypeId,
					Period = period,
					NumberofDays = leaveType.DefaultDays
				}
				);
			}
			await AddARangeAsync(allocations);
			//return employee;
		}

		public async Task<bool> AllocationExists(string employeeid, long leaveTypeId, int period)
		{
			return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeid
				&& q.LeaveTypeId == leaveTypeId
				&& q.Period == period);
		}

		public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeid)
		{
			var allocations = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.Where(q => q.EmployeeId == employeeid).ToListAsync();


			var employee = await userManager.FindByIdAsync(employeeid);

			var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
			employeeAllocationModel.leaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

			return employeeAllocationModel;
		}
		public async Task<LeaveAllocationEditLVM> GetEmployeeAllocation(long id)
		{
			var allocation = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.FirstOrDefaultAsync(q => q.Id == id);

			if (allocation == null) return null;

			var employee = await userManager.FindByIdAsync(allocation.EmployeeId);


			var model = mapper.Map<LeaveAllocationEditLVM>(allocation);
			model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));

			//employeeAllocationModel.leaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

			return model;
		}

		public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditLVM model)
		{
			var leaveAllocation = await  GetAsync(model.Id);
			if (leaveAllocation == null)
			{
				return false;
			}
			leaveAllocation.Period = model.Period;
			leaveAllocation.NumberofDays = model.NumberofDays;
			await UpdateAsync(leaveAllocation);

			return true;

			
		}

	}
}
