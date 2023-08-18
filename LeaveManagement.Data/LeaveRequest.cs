using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data
{
	public class LeaveRequest: BaseEntity
	{
		
		[ForeignKey("LeaveTypeId")]
		public LeaveType LeaveType { get; set; }
	
		public long LeaveTypeId { get; set; }

		
		public DateTime StartDate { get; set; }
		
		public DateTime EndDate { get; set; }
		public bool Cancelled { get; set; }
		public bool? Approved { get; set; }
		
		public DateTime DateRequested { get; set; }
		public string? RequestComments { get; set; }
		
		public string RequestingEmployeeId { get; set; }
			}
}
