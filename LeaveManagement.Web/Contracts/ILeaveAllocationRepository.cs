using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveAllocationRepository : IGeneraicRepository<LeaveAllocation>
	{
		Task LeaveAllocation(long leaveTypeId);

		Task<bool> AllocationExists(string employeeid, long leaveTypeId, int period);

		Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeid);

		Task<LeaveAllocationEditLVM> GetEmployeeAllocation(long id);
		Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditLVM model);

	}
}
