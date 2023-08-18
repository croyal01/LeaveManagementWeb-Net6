using AutoMapper;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper.QueryableExtensions;

namespace LeaveManagement.Application.Repositories
{
	public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
	{
		private readonly UserManager<Employee> userManager;
		private readonly ILeaveTypeRepository leaveTypeRepository;
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;
		private readonly AutoMapper.IConfigurationProvider configurationProvider;
		public LeaveAllocationRepository(ApplicationDbContext context, 
			UserManager<Employee> userManager,
			ILeaveTypeRepository leaveTypeRepository,
			IMapper mapper,
			AutoMapper.IConfigurationProvider configurationProvider) : base(context)
		{
			this.context = context;
			this.userManager = userManager;
			this.leaveTypeRepository = leaveTypeRepository;
			this.mapper = mapper;
			this.configurationProvider = configurationProvider;	
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
			await AddRangeAsync(allocations);
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
		public async Task<LeaveAllocationEditLVM> GetEmployeeAllocation(int Id, long LeaveTypeId)
		{
			if (Id==0)
			{
				throw new ArgumentNullException(nameof(Id));
			}

			var allocation = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.FirstOrDefaultAsync(q => q.Id == Id);

			if (allocation is null) return null;

			var employee = await userManager.FindByIdAsync(allocation.EmployeeId);


			var model = mapper.Map<LeaveAllocationEditLVM>(allocation);
			model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));

			//employeeAllocationModel.leaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

			return model;
		}
		public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, long leaveTypeId)
		{;
			if (employeeId is null ) throw new ArgumentNullException(nameof(employeeId));

			//var allocation = await context.LeaveAllocations	
			//.Include(q => q.EmployeeId == employeeId);
			//.Where(q => q.LeaveType.Id == leaveTypeId);



			return null; // allocation;
		}

		public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditLVM model)
		{
			var leaveAllocation = await GetAsync(model.Id);
			if (leaveAllocation == null)
			{
				return false;
			}
			leaveAllocation.Period = model.Period;
			leaveAllocation.NumberofDays = model.NumberofDays;
			await UpdateAsync(leaveAllocation);

			return true;


		}

		public async Task<LeaveAllocationEditLVM> GetEmployeeAllocation(int id)
		{
			var allocation = await context.LeaveAllocations
				   .Include(q => q.LeaveType)
				   .ProjectTo<LeaveAllocationEditLVM>(configurationProvider)
				   .FirstOrDefaultAsync(q => q.Id == id);

			if (allocation == null)
			{
				return null;
			}

			var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

			var model = mapper.Map<LeaveAllocationEditLVM>(allocation);
			model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));

			return model;

		}
	}

}