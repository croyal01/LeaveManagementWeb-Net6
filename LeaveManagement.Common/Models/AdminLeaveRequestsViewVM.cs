using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class AdminLeaveRequestsViewVM
    {
        [Display(Name = "Totoal number of requests")]
        public int TotalRequests { get; set; }
        [Display(Name = "Approved requests")]
        public int ApprovedReqeusts {get; set; }
        [Display(Name = "Pending requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected requests")]
        public int RejectedRequests { get; set; }
       
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
