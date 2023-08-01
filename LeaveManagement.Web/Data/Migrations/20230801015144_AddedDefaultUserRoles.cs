using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1028c16e-7a4f-45a8-b92e-b91891807d61", new DateTime(2023, 7, 31, 21, 51, 43, 985, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 7, 31, 21, 51, 43, 985, DateTimeKind.Local).AddTicks(1987), true, "AQAAAAEAACcQAAAAEChcvFocGzaoc4G1K2w4ttKAflX96xzzZFy6bCGw1dzfpsls3DN4yUAmTCxQB8zfzQ==", "7a59967d-f5ca-4015-a502-d2db89913549", "ADMIN@LOCALHOST.COM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f7ad27f3-d4d7-4335-92e8-8aef8bd14272", new DateTime(2023, 7, 31, 21, 51, 43, 991, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 7, 31, 21, 51, 43, 991, DateTimeKind.Local).AddTicks(9788), true, "AQAAAAEAACcQAAAAEDtYfSlBcI0on+vNC5TS8uf7POYTs45ycxshkUsY+6w9lx2SVD/USRJROB3dgHndrg==", "22e0e58b-e970-4479-aa60-5702c4984018", "ADMIN@LOCALHOST.COM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                column: "ConcurrencyStamp",
                value: "636d9b93-7b4e-409f-a47e-f7f46ca9d0c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                column: "ConcurrencyStamp",
                value: "85859030-4ef9-4be0-872c-1fad97bf990d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32274BF3-6899-4D73-818A-6B736D71E1B0",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2b2d1bd3-45db-4778-94d6-76018d2682ff", new DateTime(2023, 7, 28, 13, 12, 15, 909, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 7, 28, 13, 12, 15, 909, DateTimeKind.Local).AddTicks(9445), false, "AQAAAAEAACcQAAAAENJ4VoFmA+y43SsANUWjBfUIwdle8ISUhn9k8iRuot/eWWaUGJL0niXEpzcy1BNyxA==", "2ae78f5b-63f0-4404-ae45-5aa37acb3a96", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateofBirth", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "07b34b3a-d7ba-4146-805b-7afb75f93186", new DateTime(2023, 7, 28, 13, 12, 15, 919, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 7, 28, 13, 12, 15, 919, DateTimeKind.Local).AddTicks(2519), false, "AQAAAAEAACcQAAAAEMVqLcSQ4PFYm7vHH765YjXzY/0vOk9Z1Fc0tqzzOCdCPRlp0UC1YEWEHXBDadN8TQ==", "13b319fd-f45b-4fd3-a96a-93822094ac51", null });
        }
    }
}
