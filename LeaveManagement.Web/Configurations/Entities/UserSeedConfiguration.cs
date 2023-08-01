using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
	public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			var hasher = new PasswordHasher<Employee>();
			Employee n = new Employee();
			builder.HasData(
			
				new Employee
				{
					Id = "32274BF3-6899-4D73-818A-6B736D71E1B0",
					Email = "admin@localhost.com",
					NormalizedEmail = "ADMIN@LOCALHOST.COM",
					UserName = "ADMIN@LOCALHOST.COM",
					Firstname ="System",
					Lastname = "Admin",
					DateofBirth = DateTime.Now,
					DateJoined = DateTime.Now,
					PasswordHash = hasher.HashPassword(n,"P@ssword1"),
					EmailConfirmed = true			
				},
				new Employee
				{
					Id = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
					Email = "user@localhost.com",
					NormalizedEmail = "USER@LOCALHOST.COM",
					UserName = "ADMIN@LOCALHOST.COM",
					Firstname = "System",
					Lastname = "User",
					DateofBirth = DateTime.Now,
					DateJoined = DateTime.Now,
					PasswordHash = hasher.HashPassword(n, "P@ssword1"),
					EmailConfirmed = true,
				}
				);
			//throw new NotImplementedException();
		}
	}
}