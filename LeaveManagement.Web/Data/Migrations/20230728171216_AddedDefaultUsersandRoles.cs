using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateofBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9C3910EA-483A-4057-A30F-07C3B736ACB0", "636d9b93-7b4e-409f-a47e-f7f46ca9d0c1", "Administrator", "ADMINISTRATOR" },
                    { "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16", "85859030-4ef9-4be0-872c-1fad97bf990d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32274BF3-6899-4D73-818A-6B736D71E1B0", 0, "2b2d1bd3-45db-4778-94d6-76018d2682ff", new DateTime(2023, 7, 28, 13, 12, 15, 909, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 7, 28, 13, 12, 15, 909, DateTimeKind.Local).AddTicks(9445), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAENJ4VoFmA+y43SsANUWjBfUIwdle8ISUhn9k8iRuot/eWWaUGJL0niXEpzcy1BNyxA==", null, false, "2ae78f5b-63f0-4404-ae45-5aa37acb3a96", null, false, null },
                    { "7ca79698-5c1b-43c9-937c-d91b68b79e93", 0, "07b34b3a-d7ba-4146-805b-7afb75f93186", new DateTime(2023, 7, 28, 13, 12, 15, 919, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 7, 28, 13, 12, 15, 919, DateTimeKind.Local).AddTicks(2519), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMVqLcSQ4PFYm7vHH765YjXzY/0vOk9Z1Fc0tqzzOCdCPRlp0UC1YEWEHXBDadN8TQ==", null, false, "13b319fd-f45b-4fd3-a96a-93822094ac51", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9C3910EA-483A-4057-A30F-07C3B736ACB0", "32274BF3-6899-4D73-818A-6B736D71E1B0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16", "7ca79698-5c1b-43c9-937c-d91b68b79e93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9C3910EA-483A-4057-A30F-07C3B736ACB0", "32274BF3-6899-4D73-818A-6B736D71E1B0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16", "7ca79698-5c1b-43c9-937c-d91b68b79e93" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateofBirth",
                table: "AspNetUsers",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
