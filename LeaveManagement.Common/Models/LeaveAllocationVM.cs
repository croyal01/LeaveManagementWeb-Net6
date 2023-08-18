using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
	public class LeaveAllocationVM
	{
		[Required]
		public long Id { get; set; }

		[Display(Name = "Number of Days")]
		[Required]
		[Range(1, 50, ErrorMessage = "Invalid number Entered")]

		public int NumberofDays { get; set; }
		[Display(Name = "Leave Type")]
		public LeaveTypeVM? LeaveType { get; set; }

		[Display(Name = "Allocation Period")]
		[Required]
		public int Period { get; set; }
	}
}