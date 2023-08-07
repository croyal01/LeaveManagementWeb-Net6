using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaveType",
                table: "LeaveAllocations");

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "9242a2c0-24b1-4d0b-9aba-8ad564ad8718");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "5ba318d6-97ba-4e8f-90db-8e785e4f71f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "f0c5818c-670c-4dcd-86b4-f108182fab0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fd1b06a-8a13-4954-90a3-d4139d43e091", new DateTime(2023, 8, 5, 16, 24, 39, 585, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 8, 5, 16, 24, 39, 585, DateTimeKind.Local).AddTicks(1721), "AQAAAAEAACcQAAAAEDphOd6SnnYVRvE226ue0D9ScrytQMyTYIxi5bSoFadflGwtx/aWmJFmZM8/U0Y4RQ==", "1cef520d-2b28-4587-a405-c0815fe82c21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28fbe116-5101-43bf-9973-cdf94cf37e71", new DateTime(2023, 8, 5, 16, 24, 39, 609, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 8, 5, 16, 24, 39, 609, DateTimeKind.Local).AddTicks(5710), "AQAAAAEAACcQAAAAEJmzguTgGmLNPoFhNoXOs3385vZfXojBq4B4zGjWixnIxt0jUbi5upCcklaKD6CbiA==", "ddb7fcb1-f0f8-4d4b-8c19-1d7563c5b792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa51986e-7f6d-4ad6-aa87-c36a49861646", new DateTime(2023, 8, 5, 16, 24, 39, 598, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 8, 5, 16, 24, 39, 598, DateTimeKind.Local).AddTicks(3061), "AQAAAAEAACcQAAAAEPzZ3zfq4igSUkUz3WTP+bMDq0MI3+VNc8b7UeyCbVd8cQLB6FvCfVBcm1s66c+HMw==", "da656bb0-255b-4334-aff6-43827f0be019" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.AddColumn<string>(
                name: "LeaveType",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1b94a4-7738-4be6-a329-f1a57988e738", new DateTime(2023, 8, 2, 10, 18, 34, 337, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 8, 2, 10, 18, 34, 337, DateTimeKind.Local).AddTicks(2234), "AQAAAAEAACcQAAAAEPN3556TiuRkaSxhgDYh97fMf9wSBxQ+yWBSRAGIOpdNv1f802eB6U29LUNTOQb1YA==", "a5d80821-7703-4cc3-ad84-ef7c100f1e2a" });
        }
    }
}
