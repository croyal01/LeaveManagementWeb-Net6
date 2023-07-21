using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
	public class Employee:IdentityUser
	{	public string? Firstname { get; set; }
		public string? Lastname { get; set; }
		public string? TaxId { get; set; } 
		public string DateofBirth { get; set; }
		public string DateJoined { get; set; }

	}
}
