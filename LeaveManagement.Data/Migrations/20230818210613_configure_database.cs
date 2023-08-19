using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class configure_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                column: "ConcurrencyStamp",
                value: "04465d1c-e913-412e-87a1-bec6ba14cfac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "45b31028-3d22-4eec-bdb6-efe11ce630ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "fdc5544d-0219-4712-b163-745496b3ffe1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d9bba53-e460-4667-bac7-557f2c22431a", new DateTime(2023, 8, 18, 17, 6, 12, 773, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 8, 18, 17, 6, 12, 773, DateTimeKind.Local).AddTicks(5850), "AQAAAAEAACcQAAAAEB8veJaxQg/Fs/pzH7/SmWvT4CgMpg3tYrLv3Q1q1KrDQIX5wqDRd5tFv6hwgWHAEw==", "50450275-d4b1-4b8d-be48-eac34a4b0f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a044f329-0699-4edd-8793-44e7d84aa7a8", new DateTime(2023, 8, 18, 17, 6, 12, 787, DateTimeKind.Local).AddTicks(5651), new DateTime(2023, 8, 18, 17, 6, 12, 787, DateTimeKind.Local).AddTicks(5647), "AQAAAAEAACcQAAAAEETUuoRm0A3hlgQvr0/gfiJKWpdTloGD9ylSuHl+LXotzggr0JVapc+hQ5eIxkhO6w==", "ea0ab6ff-0226-47ec-9dac-7b7f48bb86f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63d454b2-0059-486e-85ea-343857446c53", new DateTime(2023, 8, 18, 17, 6, 12, 780, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 8, 18, 17, 6, 12, 780, DateTimeKind.Local).AddTicks(6332), "AQAAAAEAACcQAAAAEEKbEYJR0xTXf54MK3/wLB4HWEMVoPrLz6f5rr2z0aEMGmLsWSuFdsSgFWixlNDtgg==", "337f3bee-7b1f-447d-8206-743c6eb5814b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
