using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Repositories;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveRequestRepository : IGeneraicRepository<LeaveRequest>
	{
		public Task CreateLeaveRequest(LeaveRequestCreateVM model);
		public Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
		public Task <List<LeaveRequest>> GetAllAsync(string employeeId);
	}
}
