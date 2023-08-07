using LeaveManagement.Web.Data;
using System;
using System.ComponentModel.DataAnnotations;



namespace LeaveManagement.Web.Models
{

	public class LeaveRequestVM
	{
		[Display(Name = "Leave Type")]
		
		public LeaveType LeaveTypes { get; set; }

		[Display(Name = "Leave Type Id")]
		public long LeaveTypeId { get; set; }

		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }
		[Display(Name = "End Date")]
		public DateTime EndDate { get; set; }
		public bool Cancelled { get; set; }
		public bool? Approved { get; set; }
		[Display(Name = "Date Requested")]
		public DateTime DateRequested { get; set; }
		public string? RequestComments { get; set; }
		[Display(Name = "Requesting Employee Id")]
		public string? RequestingEmployeeId { get; set; }
	}
}
