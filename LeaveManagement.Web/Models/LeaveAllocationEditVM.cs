namespace LeaveManagement.Web.Models
{
	public class LeaveAllocationEditLVM : LeaveAllocationVM
	{
		public string EmployeeId { get; set; }
		public long LeaveTypeId { get; set; }
		public EmployeeListVM? Employee { get; set; }
	}
}
