using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateDBWithNewUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "7ca79698-5c1b-43c9-937c-d91b68b79e93" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "5D2DBC83-6023-4867-BDA5-7D2E68217056" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac35ca5-c798-499d-9e5e-64b240988ac9", new DateTime(2023, 7, 31, 22, 22, 59, 825, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 7, 31, 22, 22, 59, 825, DateTimeKind.Local).AddTicks(5743), "AQAAAAEAACcQAAAAEDsx7+5JtlX27PGfBLYfRlHFGASIh8/L8vuVrtkhLOrMEIDyinTnkc9v4f9x/UF2Fw==", "81a3587d-5f0a-43fc-a8fe-364b0e7ce6b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5D2DBC83-6023-4867-BDA5-7D2E68217056",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "920d333e-18ac-4542-bdaf-62f150cb2438", new DateTime(2023, 7, 31, 22, 22, 59, 843, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 7, 31, 22, 22, 59, 843, DateTimeKind.Local).AddTicks(844), "AQAAAAEAACcQAAAAECESosBNVAByHPx9zfGh8e3zI3AZCxhlKDo9O7SQ+IzEZzZ7ODtclej1YWylOoOndw==", "b4028a39-1e66-445c-b4c1-9e8203945290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe26bec-f59f-49c0-be38-980127170dad", new DateTime(2023, 7, 31, 22, 22, 59, 834, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 7, 31, 22, 22, 59, 834, DateTimeKind.Local).AddTicks(7407), "AQAAAAEAACcQAAAAEJEnIccn5TkhyiIo+CY0bLA84C4DnTlA6bDQk2yEGu7cc2lFGj4/Z66B/LGv0dDY7g==", "8cc9ebe7-2bd0-4e24-a802-1df448afae6d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "5D2DBC83-6023-4867-BDA5-7D2E68217056" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "ce4e298d-b566-4f07-8388-1d56b0d6b571");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5D1DBC83-6022-4867-BCA5-7D2E88217056", "7ca79698-5c1b-43c9-937c-d91b68b79e93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f722e38-c53c-4985-a70f-d07c6b5e6bca", new DateTime(2023, 7, 31, 22, 17, 30, 343, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 7, 31, 22, 17, 30, 343, DateTimeKind.Local).AddTicks(127), "AQAAAAEAACcQAAAAEGHUr/KalC04M67TCsdTRPwF5vL27qhgSJL74R0AsYUkTu7f2J0oS0ZgVrWHwo7p4A==", "22eacff3-857e-4ea9-a7a4-a8d8329f5f93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5D2DBC83-6023-4867-BDA5-7D2E68217056",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2b5ba6-5114-4aad-be92-872d29a94e94", new DateTime(2023, 7, 31, 22, 17, 30, 361, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 7, 31, 22, 17, 30, 361, DateTimeKind.Local).AddTicks(8016), "AQAAAAEAACcQAAAAEGaph5er+bF7mxkCB8TTzz8HvZjBakrwv/DgcozqzftiCHTpKGUh2o0Z7kKJ7i+FDA==", "3eb93b21-3613-4798-b639-fe96c781f657" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b40426-bb4e-468e-acea-88e9c2a2dc4c", new DateTime(2023, 7, 31, 22, 17, 30, 351, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 7, 31, 22, 17, 30, 351, DateTimeKind.Local).AddTicks(8098), "AQAAAAEAACcQAAAAEMM5Y7asv1iiQiqXZ/rfPyNkv/da5qoumDyIFhCxp4p9asMWBPnBT1WFqHWSddoz2g==", "0494f98e-5ad6-4db9-84c6-ad52d53e6e7b" });
        }
    }
}
