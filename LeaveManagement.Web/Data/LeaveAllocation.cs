using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
	public class LeaveAllocation: BaseEntity
	{
		//public long Id { get; set; }
		public int NumberofDays { get; set; }

		[ForeignKey("LeaveTypeId")]
		public LeaveType LeaveType { get; set; }
		public long LeaveTypeId { get; set; }

		public string EmployeeID { get; set; }

		public int Period { get; set; }

		public bool? IsDeleted { get; set; }
	}
}
