using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
	public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			var hasher = new PasswordHasher<Employee>();
			builder.HasData(
	
				new IdentityUserRole<string>
				{
					RoleId = "9C3910EA-483A-4057-A30F-07C3B736ACB0",
					UserId = "32274BF3-6899-4D73-818A-6B736D71E1B0"
				},
				new IdentityUserRole<string>
				{
					RoleId = "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
					UserId = "7ca79698-5c1b-43c9-937c-d91b68b79e93"
				},
				new IdentityUserRole<string>
				{
					RoleId = "5D1DBC83-6022-4867-BCA5-7D2E88217056",
					UserId = "6DA8BD90-197F-4B57-92A8-5DB1E912F01A"
				}
				);
			//throw new NotImplementedException();
		}
	}
}