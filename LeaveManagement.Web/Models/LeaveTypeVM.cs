﻿using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
	public class LeaveTypeVM
	{

		public long Id { get; set; }

		[Display(Name = "Leave Type Name")]
		[Required]

		public string? Name { get; set; }
		[Display (Name = "Default Number of Days")]
		[Required]
		[Range(1,25, ErrorMessage ="Please Enter a Valid Number between 1 and 25")]
		public int DefaultDays { get; set; }

		
	}
}
