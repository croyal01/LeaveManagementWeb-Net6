using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateDBWithNewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "985c2870-59be-451e-b67e-b69ad62f0a39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "8872385b-963d-4b75-a8b6-d7b96d7ed484");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "ce4e298d-b566-4f07-8388-1d56b0d6b571", "Supervisor", "SUPERVISOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f722e38-c53c-4985-a70f-d07c6b5e6bca", new DateTime(2023, 7, 31, 22, 17, 30, 343, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 7, 31, 22, 17, 30, 343, DateTimeKind.Local).AddTicks(127), "AQAAAAEAACcQAAAAEGHUr/KalC04M67TCsdTRPwF5vL27qhgSJL74R0AsYUkTu7f2J0oS0ZgVrWHwo7p4A==", "22eacff3-857e-4ea9-a7a4-a8d8329f5f93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b40426-bb4e-468e-acea-88e9c2a2dc4c", new DateTime(2023, 7, 31, 22, 17, 30, 351, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 7, 31, 22, 17, 30, 351, DateTimeKind.Local).AddTicks(8098), "AQAAAAEAACcQAAAAEMM5Y7asv1iiQiqXZ/rfPyNkv/da5qoumDyIFhCxp4p9asMWBPnBT1WFqHWSddoz2g==", "0494f98e-5ad6-4db9-84c6-ad52d53e6e7b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5D2DBC83-6023-4867-BDA5-7D2E68217056", 0, "4e2b5ba6-5114-4aad-be92-872d29a94e94", new DateTime(2023, 7, 31, 22, 17, 30, 361, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 7, 31, 22, 17, 30, 361, DateTimeKind.Local).AddTicks(8016), "supervisor@localhost.com", true, "System", "User", false, null, "SUPERVISOR@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGaph5er+bF7mxkCB8TTzz8HvZjBakrwv/DgcozqzftiCHTpKGUh2o0Z7kKJ7i+FDA==", null, false, "3eb93b21-3613-4798-b639-fe96c781f657", null, false, "SUPERVISOR@LOCALHOST.COM" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "7ca79698-5c1b-43c9-937c-d91b68b79e93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "7ca79698-5c1b-43c9-937c-d91b68b79e93" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5D2DBC83-6023-4867-BDA5-7D2E68217056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "becc0c2d-461e-47d3-a6d4-24c89924266e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "ba79eefe-4a79-44c4-aad5-7d7b043ba17f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1028c16e-7a4f-45a8-b92e-b91891807d61", new DateTime(2023, 7, 31, 21, 51, 43, 985, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 7, 31, 21, 51, 43, 985, DateTimeKind.Local).AddTicks(1987), "AQAAAAEAACcQAAAAEChcvFocGzaoc4G1K2w4ttKAflX96xzzZFy6bCGw1dzfpsls3DN4yUAmTCxQB8zfzQ==", "7a59967d-f5ca-4015-a502-d2db89913549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ad27f3-d4d7-4335-92e8-8aef8bd14272", new DateTime(2023, 7, 31, 21, 51, 43, 991, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 7, 31, 21, 51, 43, 991, DateTimeKind.Local).AddTicks(9788), "AQAAAAEAACcQAAAAEDtYfSlBcI0on+vNC5TS8uf7POYTs45ycxshkUsY+6w9lx2SVD/USRJROB3dgHndrg==", "22e0e58b-e970-4479-aa60-5702c4984018" });
        }
    }
}
