using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class StartOver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LeaveAllocations",
                type: "bit",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fbf7a71-bed1-4050-9aca-8d8cc25f01ff", new DateTime(2023, 8, 1, 13, 51, 6, 901, DateTimeKind.Local).AddTicks(9469), new DateTime(2023, 8, 1, 13, 51, 6, 901, DateTimeKind.Local).AddTicks(9443), "AQAAAAEAACcQAAAAEGonZ8r6uPm6TBLLijXEleuFc68P7oI9yLUmOp3P6zMVP3JYQwlga9F2xpYxERDH+A==", "729afb57-f7c9-499e-a37f-37a04d5887b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "9219c9d7-5f8d-4a0b-a942-c7885f483c4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "81726b59-e8bb-4480-b4be-62e6e62f1c33");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "ceba8579-d6d3-450c-a051-d1e70fe8ea1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0567388a-f82c-490a-b115-8c1bb079b597", new DateTime(2023, 8, 1, 13, 38, 22, 972, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 8, 1, 13, 38, 22, 972, DateTimeKind.Local).AddTicks(1496), "AQAAAAEAACcQAAAAEB2w/iPKrkOFlzWF8UHpV/z8zGBC1pQTo8c6E72Xn/DYJSmyCFbsmdFe0obEqDt4ow==", "27da4751-620f-44d0-83d5-1092f6abf463" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e097727c-6350-42b8-8207-cca70e1e51e0", new DateTime(2023, 8, 1, 13, 38, 22, 999, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 8, 1, 13, 38, 22, 999, DateTimeKind.Local).AddTicks(4560), "AQAAAAEAACcQAAAAEDXKCVclSOaxPO63DClKiuV+loeYs3+o/+U6tDnEYESCJU+xxCokLU7ZKYBtEiphCA==", "bb66e54e-1765-4b37-b63d-6c32d5b40ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad17ba53-db06-4592-ad62-931cb6874a1c", new DateTime(2023, 8, 1, 13, 38, 22, 984, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 8, 1, 13, 38, 22, 984, DateTimeKind.Local).AddTicks(2040), "AQAAAAEAACcQAAAAEO1iMB75aMLm3C/FHkcT1F8F0ilbgytxueYCkgzSHRVK1hhOnsxufCF9s/BMK9YYag==", "657659dd-9f2d-4533-8641-c6a177876924" });
        }
    }
}
