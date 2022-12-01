using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudgetApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bugets",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReccursOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimesReccuring = table.Column<int>(type: "int", nullable: false),
                    IsReccuring = table.Column<bool>(type: "bit", nullable: false),
                    BudgetId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Bugets_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Bugets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bugets",
                columns: new[] { "Id", "Balance" },
                values: new object[] { (byte)1, 100.0m });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[] { new Guid("f121ff9a-bec3-4d1b-b891-d05ddd48b19c"), 100m, (byte)1, new DateTime(2022, 12, 1, 10, 17, 8, 119, DateTimeKind.Local).AddTicks(9532), 0, false, "Initial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BudgetId",
                table: "Transactions",
                column: "BudgetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Bugets");
        }
    }
}
