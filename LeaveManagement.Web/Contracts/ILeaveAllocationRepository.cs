using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveAllocationRepository : IGeneraicRepository<LeaveAllocation>
	{
		Task LeaveAllocation(long leaveTypeId);

		Task<bool> AllocationExists(string employeeid, long leaveTypeId, int period);

		Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeid);

		Task<LeaveAllocationEditLVM> GetEmployeeAllocation(string id); //long LeaveTypeId)
		Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditLVM model);
		//Task<ActionResult> GetEmployeeAllocation(int id);
		
	}
}
