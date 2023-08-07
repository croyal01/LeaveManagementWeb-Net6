using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Repositories
{
	public class LeaveRequestRepository : ILeaveRequestRepository
	{
		public Task AddARangeAsync(List<LeaveRequest> Entities)
		{
			throw new NotImplementedException();
		}

		public Task<LeaveRequest> AddAsync(LeaveRequest entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsyc(long id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Exists(long id)
		{
			throw new NotImplementedException();
		}

		public Task<List<LeaveRequest>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<List<LeaveRequest>> GetAllAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<LeaveRequest> GetAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(LeaveRequest entity)
		{
			throw new NotImplementedException();
		}
	}
}
