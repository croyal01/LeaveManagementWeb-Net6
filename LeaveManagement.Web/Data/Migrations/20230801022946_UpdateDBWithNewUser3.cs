using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateDBWithNewUser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "5D2DBC83-6023-4867-BDA5-7D2E68217056" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5D2DBC83-6023-4867-BDA5-7D2E68217056");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "8c683f56-285a-4d09-81c7-373bfdad1096");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "faf117fe-d451-43b2-b193-b8c9e033013b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "da173a29-6bae-4b53-b276-f03653b73be7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "127e06b0-9ec3-474e-9534-2929b41318df", new DateTime(2023, 7, 31, 22, 29, 46, 154, DateTimeKind.Local).AddTicks(6895), new DateTime(2023, 7, 31, 22, 29, 46, 154, DateTimeKind.Local).AddTicks(6858), "AQAAAAEAACcQAAAAEENqLLB70eBjniPFmxLxFOVtFXlBzoWVK4nXFsHcEk5jQOwZ9ihTfKX+89Gnfbj0FA==", "afa77fa8-9558-4a30-8402-4d9698338abe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37beebc9-800c-4f57-898e-6dc42ba06918", new DateTime(2023, 7, 31, 22, 29, 46, 162, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 7, 31, 22, 29, 46, 162, DateTimeKind.Local).AddTicks(6160), "AQAAAAEAACcQAAAAEGX/Uv1bT5LODNwyWAdXV5W6qrTQF+Uvi5vFuVED7t5HQa7Ly11vuYLu5QOKg7UtSg==", "a3d97a55-dbd4-409c-831c-e4b8a111d333" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6DA8BD90-197F-4B57-92A8-5DB1E912F01A", 0, "24c44e5e-85ee-4108-b8d5-66224b8f125c", new DateTime(2023, 7, 31, 22, 29, 46, 171, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 7, 31, 22, 29, 46, 171, DateTimeKind.Local).AddTicks(5545), "supervisor@localhost.com", true, "System", "User", false, null, "SUPERVISOR@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMKaCNKw4kZptHKWBwfNqxzx2YwpAUVT0AAHCbiMycxzk1LnGFBFZ92sPBtj2JLOow==", null, false, "93760afc-3fcc-4afd-8be8-9c725fe2458b", null, false, "SUPERVISOR@LOCALHOST.COM" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "6DA8BD90-197F-4B57-92A8-5DB1E912F01A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "6DA8BD90-197F-4B57-92A8-5DB1E912F01A" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "b9f767a2-e0a4-4137-86c1-c55685645ffa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "b0c6ee3e-4807-4f08-a83c-a9cf33da09f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "c39720ae-4813-4eb7-b41c-2ba9694a84a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac35ca5-c798-499d-9e5e-64b240988ac9", new DateTime(2023, 7, 31, 22, 22, 59, 825, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 7, 31, 22, 22, 59, 825, DateTimeKind.Local).AddTicks(5743), "AQAAAAEAACcQAAAAEDsx7+5JtlX27PGfBLYfRlHFGASIh8/L8vuVrtkhLOrMEIDyinTnkc9v4f9x/UF2Fw==", "81a3587d-5f0a-43fc-a8fe-364b0e7ce6b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe26bec-f59f-49c0-be38-980127170dad", new DateTime(2023, 7, 31, 22, 22, 59, 834, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 7, 31, 22, 22, 59, 834, DateTimeKind.Local).AddTicks(7407), "AQAAAAEAACcQAAAAEJEnIccn5TkhyiIo+CY0bLA84C4DnTlA6bDQk2yEGu7cc2lFGj4/Z66B/LGv0dDY7g==", "8cc9ebe7-2bd0-4e24-a802-1df448afae6d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5D2DBC83-6023-4867-BDA5-7D2E68217056", 0, "920d333e-18ac-4542-bdaf-62f150cb2438", new DateTime(2023, 7, 31, 22, 22, 59, 843, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 7, 31, 22, 22, 59, 843, DateTimeKind.Local).AddTicks(844), "supervisor@localhost.com", true, "System", "User", false, null, "SUPERVISOR@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAECESosBNVAByHPx9zfGh8e3zI3AZCxhlKDo9O7SQ+IzEZzZ7ODtclej1YWylOoOndw==", null, false, "b4028a39-1e66-445c-b4c1-9e8203945290", null, false, "SUPERVISOR@LOCALHOST.COM" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "5D2DBC83-6023-4867-BDA5-7D2E68217056" });
        }
    }
}
