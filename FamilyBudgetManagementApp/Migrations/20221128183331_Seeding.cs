using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudgetApp.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bugets",
                columns: new[] { "Id", "Balance" },
                values: new object[] { (byte)1, 0.0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bugets",
                keyColumn: "Id",
                keyValue: (byte)1);
        }
    }
}
