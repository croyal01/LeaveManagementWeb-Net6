using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "8f883ad4-2fcf-48e4-8559-01c154aab80a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "848626d8-e147-4d3c-8d21-b552c39606e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "650f64fb-c145-4ba2-b950-33128d1b89d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a1e7dd5-32ab-4353-9a7f-0232388cef18", new DateTime(2023, 8, 2, 10, 18, 34, 327, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 8, 2, 10, 18, 34, 327, DateTimeKind.Local).AddTicks(5718), "AQAAAAEAACcQAAAAEOrHvtIy8Qv4B5mZamuZSOCM3q8Slms9ctuHwNbvj2sfdvyl3+zX05Sfke6IYyJbyw==", "264d9cf7-2095-49c9-9a79-3f682d72e52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23da8491-6937-4c81-a106-f57d9e085bed", new DateTime(2023, 8, 2, 10, 18, 34, 346, DateTimeKind.Local).AddTicks(5937), new DateTime(2023, 8, 2, 10, 18, 34, 346, DateTimeKind.Local).AddTicks(5891), "AQAAAAEAACcQAAAAENBjbMwGYBM2w6YzsvdKBYK+LAiTf6hiNgp9Z4UDOfXIYYwYrY3arHmPOtmefGIP6g==", "aaff546a-7318-482b-98b9-111f2b2bcae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5a1b94a4-7738-4be6-a329-f1a57988e738", new DateTime(2023, 8, 2, 10, 18, 34, 337, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 8, 2, 10, 18, 34, 337, DateTimeKind.Local).AddTicks(2234), "AQAAAAEAACcQAAAAEPN3556TiuRkaSxhgDYh97fMf9wSBxQ+yWBSRAGIOpdNv1f802eB6U29LUNTOQb1YA==", "a5d80821-7703-4cc3-ad84-ef7c100f1e2a", "USER@LOCALHOST.COM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "9b8d75e5-ed0d-4a15-a1d3-b54ed5c6f420");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "476b260a-7936-4933-88b5-bcb7a1d7ad02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "57439b12-ca61-4b45-8e20-8376f4cdbdd9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97aeb8c9-379e-4300-afcc-c4030afa131c", new DateTime(2023, 8, 1, 13, 51, 6, 894, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 8, 1, 13, 51, 6, 894, DateTimeKind.Local).AddTicks(3269), "AQAAAAEAACcQAAAAEAbXmRpuQohkeuqgPOg6xGj+eHG8Afgc9Z6Hct3b6nylk18GRKLdsHY1TzUGxEyPSg==", "54723b4e-466d-49ae-9e0b-36f041d1c75f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea2c47e8-74f4-4517-abde-eb4e17af0d53", new DateTime(2023, 8, 1, 13, 51, 6, 908, DateTimeKind.Local).AddTicks(9334), new DateTime(2023, 8, 1, 13, 51, 6, 908, DateTimeKind.Local).AddTicks(9329), "AQAAAAEAACcQAAAAEBp9lQfJy5CiTCstRgy7hF3BUryvpotNL9nz7Z1HFvondeJEgPU8SLyLOWuFs2l5ag==", "dbedc144-4a92-446f-a6fc-08fe3624b2b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0fbf7a71-bed1-4050-9aca-8d8cc25f01ff", new DateTime(2023, 8, 1, 13, 51, 6, 901, DateTimeKind.Local).AddTicks(9469), new DateTime(2023, 8, 1, 13, 51, 6, 901, DateTimeKind.Local).AddTicks(9443), "AQAAAAEAACcQAAAAEGonZ8r6uPm6TBLLijXEleuFc68P7oI9yLUmOp3P6zMVP3JYQwlga9F2xpYxERDH+A==", "729afb57-f7c9-499e-a37f-37a04d5887b2", "ADMIN@LOCALHOST.COM" });
        }
    }
}
