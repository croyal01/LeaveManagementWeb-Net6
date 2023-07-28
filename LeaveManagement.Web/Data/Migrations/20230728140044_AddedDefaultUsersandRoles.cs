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
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ca79698-5c1b-43c9-937c-d91b68b79e93", "cda1fd3a-d98f-4370-9006-570fadaf0645", "Administrator", "ADMINISTRATOR" },
                    { "C958C67E-A2BB-464A-90BE-C296B5138C42", "36dab8b3-e821-4ae3-a411-4e3eea0c0798", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32274BF3-6899-4D73-818A-6B736D71E1B0", 0, "75944251-cbbe-4b66-98d1-4785add5f269", null, null, "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJ9cyinLi2vyzH/vUekZaBfYBNgd8SLDCoC6Ck68ul/whaqFc4TEizM9rsICEAm+ng==", null, false, "e9765a22-ec13-44ac-95e4-eb8886f14538", null, false, null },
                    { "7ca79698-5c1b-43c9-937c-d91b68b79e93", 0, "2f3111f5-3005-4704-a870-ee21bf811abb", null, null, "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAECGn1QBLUIOgmr+vzm4KfWCA0Jgdb+Qsh1/1PhRIyVF6uvrDugyG2cfkybNdWlyRZA==", null, false, "fb1bd75a-cb14-407a-aea8-e8a4dca91aab", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ca79698-5c1b-43c9-937c-d91b68b79e93", "32274BF3-6899-4D73-818A-6B736D71E1B0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ca79698-5c1b-43c9-937c-d91b68b79e93", "670069df-7000-45f3-9aea-a730334c5631" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C958C67E-A2BB-464A-90BE-C296B5138C42");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ca79698-5c1b-43c9-937c-d91b68b79e93", "32274BF3-6899-4D73-818A-6B736D71E1B0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ca79698-5c1b-43c9-937c-d91b68b79e93", "670069df-7000-45f3-9aea-a730334c5631" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0");

            migrationBuilder.AlterColumn<string>(
                name: "DateofBirth",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
