using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Data
{
	public abstract class BaseEntity
	{
		public long Id { get; set; }

		[Display(Name = "Date Created")] 
		public DateTime DateCreated { get; set; }

		[Display(Name = "Date Moified")]
		public DateTime DateModified { get; set; }
	}
}
