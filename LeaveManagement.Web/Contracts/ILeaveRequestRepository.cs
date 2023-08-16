using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Repositories;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveRequestRepository : IGeneraicRepository<LeaveRequest>
	{
		Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);


		Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
		Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);
		Task<AdminLeaveRequestsViewVM> GetAdminLeaveRequestList();



		Task ChangeApprovalStatus(int leaveRequestId, bool approved);
		Task CancelLeaveRequest(int leaveRequestId);

		Task<LeaveRequestVM> GetLeaveRequestAsync(int? id);

	}
}
