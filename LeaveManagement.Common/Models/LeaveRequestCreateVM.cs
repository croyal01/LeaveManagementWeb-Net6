using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Common.Models
{
	public class LeaveRequestCreateVM: IValidatableObject
	{
				
		[Display(Name = "Leave Type Id")]
		public long LeaveTypeId { get; set; }
		//public SelectList? LeaveTypes { get; set; }
		public SelectList LeaveTypes { get; set; }

		[Required]
		[Display(Name = "Start Date")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime? StartDate { get; set; }
		
		[Required]
		[Display(Name = "End Date")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime? EndDate { get; set; }
		public string? RequestComments { get; set; }

		[Display(Name ="Requested Date")]
		public DateTime DateRequested { get; set; }

		[Display(Name = "Requestoing Employee ID")]
		//public string RequestingEmployeeId { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (StartDate > EndDate)
			{
				yield return new ValidationResult("The start date must be before end date", new[] { nameof(StartDate), nameof(EndDate) });
			}
			if (RequestComments.Length > 250)
			{
				yield return new ValidationResult("The comment exceeded 250 characters", new[] { nameof(RequestComments) });
			}

		}
}
}



