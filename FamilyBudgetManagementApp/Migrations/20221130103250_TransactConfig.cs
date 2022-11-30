using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudgetApp.Migrations
{
    public partial class TransactConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[] { new Guid("6cedd608-1300-4189-8a27-68c55401a55d"), 100m, (byte)1, new DateTime(2022, 11, 30, 12, 32, 49, 828, DateTimeKind.Local).AddTicks(3623), 0, false, "Initial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6cedd608-1300-4189-8a27-68c55401a55d"));
        }
    }
}
