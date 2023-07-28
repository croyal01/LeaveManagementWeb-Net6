using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
	public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			var hasher = new PasswordHasher<Employee>();
			builder.HasData(
			
				new IdentityUserRole<string>
				{
					RoleId = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
					UserId = "32274BF3-6899-4D73-818A-6B736D71E1B0"
				},
				new IdentityUserRole<string>
				{
					RoleId = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
					UserId = "670069df-7000-45f3-9aea-a730334c5631"
				}
				);
			//throw new NotImplementedException();
		}
	}
}