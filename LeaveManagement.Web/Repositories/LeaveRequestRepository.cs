using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
	public class LeaveRequestRepository : IGenericRepository<LeaveRequest>, ILeaveRequestRepository
	{
		private readonly ILeaveRequestRepository _leaveRequestRepository;
		private readonly IHttpContextAccessor httpContextAccessor;
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;
		private readonly UserManager<Employee> userManager;
		private readonly ILeaveAllocationRepository leaveAllocationRepository;
		private readonly ILeaveTypeRepository leaveTypeRepository;
		//private readonly ILeaveAllocationRepository leaveAllocationRepository;
		//private readonly IEmailSender emailSender;


		public LeaveRequestRepository(ApplicationDbContext context,
			IMapper mapper,
			IHttpContextAccessor httpContextAccessor,
			ILeaveAllocationRepository leaveAllocationRepository,
			UserManager<Employee> userManager,
			ILeaveTypeRepository leaveTypeRepository) : base(context)
		{
			this.context = context;
			this.mapper = mapper;
			this.httpContextAccessor = httpContextAccessor;
			this.userManager = userManager;
			this.leaveTypeRepository = leaveTypeRepository;
		}




		public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
		{
			var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext?.User);
			var leaveRequest = mapper.Map<LeaveRequest>(model);
			leaveRequest.DateRequested = DateTime.Now;
			leaveRequest.RequestingEmployeeId = user.Id;
			leaveRequest.Cancelled = false;
			leaveRequest.DateCreated = DateTime.Now;
			leaveRequest.DateModified = DateTime.Now;
			await AddAsync(leaveRequest);

		}

		public async Task<List<LeaveRequest>> GetAllAsync(string employeeid)
		{
			return await context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeid).ToListAsync();
        }
		public async Task<EmployeeLeaveRequestVM> GetMyLeaveDetails()
		{
			var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext?.User);
			var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id)).leaveAllocations;
			var request = mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));

			var model = new EmployeeLeaveRequestViewVM(allocations, request);

			return model;
			
		}
	}
}
