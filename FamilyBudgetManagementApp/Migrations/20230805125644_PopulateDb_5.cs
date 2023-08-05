using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudgetApp.Migrations
{
    public partial class PopulateDb_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("05fb27ba-f36d-4cfe-ad79-01d3bfce1586"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0f469323-6b91-4faa-9af7-fe0ce8749666"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("118eec24-4198-4184-8f57-0aeceb185e99"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7d6792f0-cdc5-4b6c-a5c8-208e6c0947af"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9652778b-7a9c-486d-8e12-de5e53d9fc37"));

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[,]
                {
                    { new Guid("3d3704c0-b98c-49ce-8881-2f90880e4d49"), 335m, (byte)1, new DateTime(2023, 1, 31, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5280), 0, true, "Transaction 3", new DateTime(2023, 9, 3, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5282), 9, 1 },
                    { new Guid("bfab6662-ae8e-4753-bf3f-bc970435ada2"), 26m, (byte)1, new DateTime(2023, 1, 30, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5274), 0, true, "Transaction 2", new DateTime(2023, 8, 10, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5275), 2, 0 },
                    { new Guid("ebc4801f-50ab-4a48-9127-38392c851442"), 580m, (byte)1, new DateTime(2023, 6, 27, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5291), 0, true, "Transaction 5", new DateTime(2023, 8, 25, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5293), 8, 0 },
                    { new Guid("efca934e-ad52-4d8f-a34b-6643eb9a03c6"), 860m, (byte)1, new DateTime(2022, 12, 7, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5207), 0, false, "Transaction 1", new DateTime(2023, 9, 3, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5242), 2, 1 },
                    { new Guid("f3a044c1-bcf8-4dc3-a315-da25116a9895"), 67m, (byte)1, new DateTime(2023, 4, 11, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5286), 0, false, "Transaction 4", new DateTime(2023, 8, 14, 15, 56, 43, 896, DateTimeKind.Local).AddTicks(5288), 4, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3d3704c0-b98c-49ce-8881-2f90880e4d49"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bfab6662-ae8e-4753-bf3f-bc970435ada2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ebc4801f-50ab-4a48-9127-38392c851442"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("efca934e-ad52-4d8f-a34b-6643eb9a03c6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f3a044c1-bcf8-4dc3-a315-da25116a9895"));

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[,]
                {
                    { new Guid("05fb27ba-f36d-4cfe-ad79-01d3bfce1586"), 537m, (byte)1, new DateTime(2022, 11, 16, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(347), 0, false, "Transaction 1", new DateTime(2023, 8, 22, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(380), 4, 0 },
                    { new Guid("0f469323-6b91-4faa-9af7-fe0ce8749666"), 349m, (byte)1, new DateTime(2022, 10, 27, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(394), 0, false, "Transaction 3", new DateTime(2023, 8, 20, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(395), 2, 0 },
                    { new Guid("118eec24-4198-4184-8f57-0aeceb185e99"), 760m, (byte)1, new DateTime(2023, 2, 3, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(405), 0, false, "Transaction 5", new DateTime(2023, 8, 23, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(406), 1, 0 },
                    { new Guid("7d6792f0-cdc5-4b6c-a5c8-208e6c0947af"), 589m, (byte)1, new DateTime(2023, 1, 31, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(399), 0, false, "Transaction 4", new DateTime(2023, 8, 28, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(401), 6, 0 },
                    { new Guid("9652778b-7a9c-486d-8e12-de5e53d9fc37"), 363m, (byte)1, new DateTime(2023, 2, 6, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(388), 0, true, "Transaction 2", new DateTime(2023, 8, 31, 15, 52, 15, 685, DateTimeKind.Local).AddTicks(390), 2, 0 }
                });
        }
    }
}
