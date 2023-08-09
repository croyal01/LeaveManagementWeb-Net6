using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;


namespace LeaveManagement.Web.Models
{
	public class LeaveRequestCreateVM
	{

		
		
		public SelectList LeaveTypes { get; set; }

		[Display(Name = "Leave Type Id")]
		public long LeaveTypeId { get; set; }

		[Display(Name = "Start Date")]
		public DateTime? StartDate { get; set; }
		[Display(Name = "End Date")]
		public DateTime? EndDate { get; set; }
		public string? RequestComments { get; set; }

		[Display(Name ="Requested Date")]
		public DateTime DateRequested { get; set; }


	}
}



