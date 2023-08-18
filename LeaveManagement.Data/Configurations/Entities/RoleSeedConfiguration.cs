using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagement.Common.Constants;

namespace LeaveManagement.Data.Configurations.Entities
{

	public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
				new IdentityRole
				{
					
					Id = "9C3910EA-483A-4057-A30F-07C3B736ACB0",
					Name = Roles.Administrator,
					NormalizedName = Roles.Administrator.ToUpper(),

				},
				new IdentityRole
				{
					
					Id = "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
					Name = Roles.User,
					NormalizedName = Roles.User.ToUpper(),

				},
				new IdentityRole
				{
					
					Id = "5D1DBC83-6022-4867-BCA5-7D2E88217056",
					Name = Roles.Supervisor,
					NormalizedName = Roles.Supervisor.ToUpper(),

				}
				);
			//throw new NotImplementedException();
		}
	}
}