using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
	public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
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
					EmployeeID = employee.Id,
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
			return await context.LeaveAllocations.AnyAsync(q => q.EmployeeID == employeeid
				&& q.LeaveTypeId == leaveTypeId
				&& q.Period == period);
		}

		public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeid)
		{
			var allocations = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.Where(q => q.EmployeeID == employeeid).ToListAsync();


			var employee = await userManager.FindByIdAsync(employeeid);

			var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
			employeeAllocationModel.leaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

			return employeeAllocationModel;
		}
	}

}
