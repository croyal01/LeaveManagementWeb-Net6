using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24c44e5e-85ee-4108-b8d5-66224b8f125c", new DateTime(2023, 7, 31, 22, 29, 46, 171, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 7, 31, 22, 29, 46, 171, DateTimeKind.Local).AddTicks(5545), "AQAAAAEAACcQAAAAEMKaCNKw4kZptHKWBwfNqxzx2YwpAUVT0AAHCbiMycxzk1LnGFBFZ92sPBtj2JLOow==", "93760afc-3fcc-4afd-8be8-9c725fe2458b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37beebc9-800c-4f57-898e-6dc42ba06918", new DateTime(2023, 7, 31, 22, 29, 46, 162, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 7, 31, 22, 29, 46, 162, DateTimeKind.Local).AddTicks(6160), "AQAAAAEAACcQAAAAEGX/Uv1bT5LODNwyWAdXV5W6qrTQF+Uvi5vFuVED7t5HQa7Ly11vuYLu5QOKg7UtSg==", "a3d97a55-dbd4-409c-831c-e4b8a111d333" });
        }
    }
}
