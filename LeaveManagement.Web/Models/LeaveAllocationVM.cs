using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
	public class LeaveAllocationVM
	{
		public long Id { get; set; }

		[Display(Name = "Number of Days")]
		public int NumberofDays { get; set; }
		[Display(Name = "Leave Type")]
		public LeaveTypeVM LeaveType { get; set; }

		//[Display(Name = "Date Created")]
		//public DateTime DateCreated { get; set; }

		[Display(Name = "Period")]
		public int Period { get; set; }
	}
}