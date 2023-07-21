namespace LeaveManagement.Web.Data
{
	public abstract class Base
	{
		public long Id { get; set; }
		
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
	}
}
