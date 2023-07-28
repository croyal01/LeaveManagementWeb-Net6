using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{

	internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
				new IdentityRole
				{
					Id = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
					Name = "Administrator",
					NormalizedName = "ADMINISTRATOR",

				},
				new IdentityRole
				{
					Id = "C958C67E-A2BB-464A-90BE-C296B5138C42",
					Name = "User",
					NormalizedName = "USER",

				}
				);
			//throw new NotImplementedException();
		}
	}
}