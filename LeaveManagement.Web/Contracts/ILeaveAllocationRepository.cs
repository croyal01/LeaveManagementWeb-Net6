using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveAllocationRepository : IGeneraicRepository <LeaveAllocation>
	{
		Task LeaveAllocation(long leaveTypeId);

		Task<bool> AllocationExists(string employeeid, long leaveTypeId, int period);


	}
}
