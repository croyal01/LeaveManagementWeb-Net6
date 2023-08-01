using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Configurations.Entities
{

	public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
				new IdentityRole
				{
					//Id = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
					Id = "9C3910EA-483A-4057-A30F-07C3B736ACB0",
					Name = Roles.Administrator,
					NormalizedName = Roles.Administrator.ToUpper(),

				},
				new IdentityRole
				{
					//Id = "C958C67E-A2BB-464A-90BE-C296B5138C42",
					Id = "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
					Name = Roles.User,
					NormalizedName = Roles.User.ToUpper(),

				}
				);
			//throw new NotImplementedException();
		}
	}
}