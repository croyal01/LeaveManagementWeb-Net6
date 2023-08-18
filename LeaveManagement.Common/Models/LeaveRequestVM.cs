﻿//using LeaveManagement.Data;
using System;
using System.ComponentModel.DataAnnotations;



namespace LeaveManagement.Common.Models
{

	public class LeaveRequestVM : LeaveRequestCreateVM
	{

		public long Id { get; set; }

		[Display(Name = "Date Requested")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		[DataType(DataType.Date)]
		public DateTime DateRequested { get; set; }



		[Display(Name = "Leave Type")]
		public LeaveTypeVM LeaveType { get; set; }

		public bool? Approved { get; set; }
		public bool Cancelled { get; set; }
		public EmployeeListVM Employee { get; set; }
		public string? RequestingEmployeeId { get; set; }
		
		
		 
       

        public int NumberOfDays { get; set; }
	

	}
}
