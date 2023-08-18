//using LeaveManagement.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
	public class EmployeeListVM 
	{
		public string Id { get; set; }
		[Display(Name = "First Name")]
		public string? Firstname { get; set; }
		[Display(Name = "last Name")]
		public string? Lastname { get; set; }
		[Display(Name = "Email Address")]
		public string? Email { get; set; }
		public DateTime DateJoined { get; set; }	
	}
}
