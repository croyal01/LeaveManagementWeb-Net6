using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
	public class EmployeeAllocationVM: EmployeeListVM
	{
		public List<LeaveAllocationVM> leaveAllocations { get; set; }

		

	}
}

