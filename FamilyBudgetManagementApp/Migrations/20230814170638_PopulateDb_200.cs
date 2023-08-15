using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyBudgetApp.Migrations
{
    public partial class PopulateDb_200 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("00a9781e-b60d-40c3-9b93-f79d25808644"), 899m, (byte)1, new DateTime(2023, 6, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7980), 0, false, "Transaction 75", new DateTime(2023, 8, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7982), 8, 0 },
                    { new Guid("032ee56d-28b7-4b51-aa29-c5db1190e2e6"), 585m, (byte)1, new DateTime(2023, 3, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8108), 0, false, "Transaction 99", new DateTime(2023, 9, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8110), 3, 0 },
                    { new Guid("03c3e2cd-7566-4584-a280-4389f10003ae"), 616m, (byte)1, new DateTime(2022, 12, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7626), 0, true, "Transaction 15", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7628), 2, 0 },
                    { new Guid("04e59fe5-9de9-4c63-aa21-085687ef1d6c"), 882m, (byte)1, new DateTime(2023, 6, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7572), 0, false, "Transaction 13", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7574), 8, 1 },
                    { new Guid("04fc722d-9749-461f-a765-c8651b46281e"), 862m, (byte)1, new DateTime(2022, 11, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8349), 0, false, "Transaction 138", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8351), 6, 0 },
                    { new Guid("0535dba6-1054-4e2d-b5b3-44b0f709f4f8"), 862m, (byte)1, new DateTime(2023, 4, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7655), 0, false, "Transaction 20", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7657), 3, 0 },
                    { new Guid("0611c58f-3c72-4131-96f8-3173daaa3083"), 747m, (byte)1, new DateTime(2022, 11, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7650), 0, false, "Transaction 19", new DateTime(2023, 8, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7652), 9, 1 },
                    { new Guid("0751c5ac-99a2-44f9-95c6-45e04ded9e94"), 856m, (byte)1, new DateTime(2023, 7, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8641), 0, true, "Transaction 187", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8643), 3, 0 },
                    { new Guid("084a7b6a-b53d-469c-b5ce-de91652220f0"), 704m, (byte)1, new DateTime(2023, 1, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8684), 0, true, "Transaction 195", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8685), 5, 1 },
                    { new Guid("08d0eb94-0e70-4f83-83d3-d619e32a73e8"), 377m, (byte)1, new DateTime(2022, 10, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8666), 0, true, "Transaction 192", new DateTime(2023, 8, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8668), 4, 1 },
                    { new Guid("0c30875b-b892-47c9-84c4-b2aa3b89dfbf"), 143m, (byte)1, new DateTime(2023, 7, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7789), 0, true, "Transaction 45", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7791), 3, 0 },
                    { new Guid("100cef6b-60d3-40da-80a2-fa4527529408"), 690m, (byte)1, new DateTime(2023, 6, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7567), 0, false, "Transaction 12", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7569), 5, 1 },
                    { new Guid("11ca8bb0-c6f6-4b15-a270-75a582a3f27b"), 586m, (byte)1, new DateTime(2022, 12, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7463), 0, false, "Transaction 1", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7491), 3, 1 },
                    { new Guid("12488586-a2da-45ff-8a6a-72541bd69df2"), 483m, (byte)1, new DateTime(2023, 1, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8250), 0, false, "Transaction 120", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8252), 5, 0 },
                    { new Guid("1436d1e0-54fc-471c-980c-2d168909c348"), 418m, (byte)1, new DateTime(2023, 3, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7799), 0, false, "Transaction 47", new DateTime(2023, 8, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7801), 2, 0 },
                    { new Guid("14ac0262-aa91-4408-9274-3f6830cbae9c"), 981m, (byte)1, new DateTime(2023, 5, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8492), 0, true, "Transaction 159", new DateTime(2023, 8, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8494), 7, 1 },
                    { new Guid("1629561e-70bf-4c51-984b-fe8174491ba3"), 886m, (byte)1, new DateTime(2022, 11, 14, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7714), 0, false, "Transaction 31", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7715), 3, 0 },
                    { new Guid("168c7be3-70cc-4217-98b0-b9aef5c973cd"), 122m, (byte)1, new DateTime(2022, 11, 14, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8011), 0, true, "Transaction 81", new DateTime(2023, 9, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8012), 4, 1 },
                    { new Guid("173ed9c7-f2d2-4951-b16d-85e71736c7ea"), 843m, (byte)1, new DateTime(2023, 3, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8048), 0, true, "Transaction 88", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8050), 9, 1 },
                    { new Guid("17d888aa-6057-4543-8d6d-e31d6d5707f9"), 863m, (byte)1, new DateTime(2023, 7, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8704), 0, true, "Transaction 199", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8706), 6, 1 },
                    { new Guid("1899f703-6b08-49ed-b4cf-52fa35ed23e8"), 394m, (byte)1, new DateTime(2022, 11, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7514), 0, true, "Transaction 3", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7516), 9, 0 },
                    { new Guid("18a265b1-b344-4614-84be-89dea701dc36"), 851m, (byte)1, new DateTime(2022, 11, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7863), 0, true, "Transaction 59", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7865), 5, 1 },
                    { new Guid("1907922e-c650-42ee-9cb2-23124fad2fbe"), 975m, (byte)1, new DateTime(2023, 4, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8465), 0, true, "Transaction 154", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8467), 8, 1 },
                    { new Guid("1c680dbd-c85a-4299-aff8-380dcf955653"), 620m, (byte)1, new DateTime(2023, 5, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8086), 0, false, "Transaction 95", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8087), 7, 1 },
                    { new Guid("1de712a4-63c4-499d-b126-e439749e51f6"), 403m, (byte)1, new DateTime(2023, 3, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8006), 0, false, "Transaction 80", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8007), 9, 1 },
                    { new Guid("1df12d37-923d-4a17-9759-b580b33a15cd"), 285m, (byte)1, new DateTime(2023, 1, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8145), 0, false, "Transaction 106", new DateTime(2023, 9, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8146), 9, 0 },
                    { new Guid("1f37045b-b2fb-4f3a-a09b-84547c2c0f9f"), 786m, (byte)1, new DateTime(2023, 6, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7931), 0, true, "Transaction 66", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7932), 6, 1 },
                    { new Guid("1f71b242-0985-4267-9ed7-421aa092c761"), 578m, (byte)1, new DateTime(2023, 7, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8235), 0, true, "Transaction 117", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8237), 5, 1 },
                    { new Guid("207c141f-3f95-42eb-85cd-504e506bb341"), 53m, (byte)1, new DateTime(2023, 3, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7665), 0, false, "Transaction 22", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7667), 5, 1 },
                    { new Guid("2082037b-738e-4eb6-934c-12f110fc5c43"), 317m, (byte)1, new DateTime(2022, 12, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8535), 0, false, "Transaction 167", new DateTime(2023, 9, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8537), 9, 0 },
                    { new Guid("221977c8-2c27-4859-aeb7-068617127191"), 819m, (byte)1, new DateTime(2023, 7, 14, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8372), 0, false, "Transaction 142", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8373), 6, 0 },
                    { new Guid("22c4fd40-057a-4c70-a7f9-5e0156d0d5c5"), 592m, (byte)1, new DateTime(2022, 12, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8268), 0, true, "Transaction 123", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8270), 1, 0 },
                    { new Guid("232f1848-f926-4650-b1f4-7d1ca2ecb296"), 85m, (byte)1, new DateTime(2023, 6, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8023), 0, false, "Transaction 83", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8025), 9, 0 },
                    { new Guid("245dd991-1b91-4494-be64-90b34ba9860d"), 525m, (byte)1, new DateTime(2022, 12, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8540), 0, false, "Transaction 168", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8542), 9, 1 },
                    { new Guid("25d8e9bd-8110-4925-9617-e0f34c351bd7"), 572m, (byte)1, new DateTime(2022, 12, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8192), 0, false, "Transaction 109", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8194), 9, 1 },
                    { new Guid("26fd41f7-2935-4f43-b030-e5255f65cf63"), 652m, (byte)1, new DateTime(2022, 11, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7724), 0, false, "Transaction 33", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7726), 1, 0 },
                    { new Guid("276c9053-9c22-4690-96ad-a5ac13e57fdd"), 168m, (byte)1, new DateTime(2023, 6, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7996), 0, true, "Transaction 78", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7997), 4, 1 },
                    { new Guid("2ae11fbd-26e7-4a5f-9b91-f0a5b30d325b"), 314m, (byte)1, new DateTime(2022, 11, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8615), 0, false, "Transaction 182", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8616), 8, 0 },
                    { new Guid("2b6c32cc-e3ad-459a-8db2-569bbb0bc3cd"), 943m, (byte)1, new DateTime(2023, 3, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7958), 0, true, "Transaction 71", new DateTime(2023, 9, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7959), 4, 0 },
                    { new Guid("2b9bec2f-dc7e-4ce6-ae38-22120321fa76"), 140m, (byte)1, new DateTime(2022, 11, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8114), 0, true, "Transaction 100", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8115), 5, 1 },
                    { new Guid("2da5ee59-a7f2-4c29-80c2-2401cafc2bb2"), 473m, (byte)1, new DateTime(2023, 1, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7499), 0, true, "Transaction 2", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7501), 5, 0 },
                    { new Guid("2fe4dc0e-9fe1-4f89-bdc3-bf324951a5e6"), 609m, (byte)1, new DateTime(2023, 1, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7532), 0, false, "Transaction 6", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7534), 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[,]
                {
                    { new Guid("332a6b19-bb86-4214-b33c-c16a3b381295"), 497m, (byte)1, new DateTime(2023, 3, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8091), 0, false, "Transaction 96", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8092), 3, 0 },
                    { new Guid("3347b728-6ab3-4a18-9186-22d09d9c4588"), 419m, (byte)1, new DateTime(2023, 1, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8339), 0, true, "Transaction 136", new DateTime(2023, 8, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8340), 2, 0 },
                    { new Guid("345647c9-107f-4209-9203-a52df5742c3e"), 184m, (byte)1, new DateTime(2023, 2, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7772), 0, false, "Transaction 42", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7774), 1, 0 },
                    { new Guid("358c5ca6-3284-4a4a-a538-3423dcb1f37a"), 167m, (byte)1, new DateTime(2022, 12, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8572), 0, false, "Transaction 174", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8574), 8, 1 },
                    { new Guid("35ba9de0-4d86-4b33-a544-e4b4fd48f2f0"), 892m, (byte)1, new DateTime(2023, 4, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7924), 0, false, "Transaction 65", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7926), 5, 1 },
                    { new Guid("360fb402-1a72-4d45-9f92-0ec71fe9d560"), 226m, (byte)1, new DateTime(2023, 2, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7730), 0, false, "Transaction 34", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7732), 4, 0 },
                    { new Guid("364f4e18-7943-44ed-af4f-aa989e3739c9"), 31m, (byte)1, new DateTime(2023, 5, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7520), 0, true, "Transaction 4", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7521), 5, 0 },
                    { new Guid("3972ebaa-d28c-46a8-9b9e-742519baecb9"), 646m, (byte)1, new DateTime(2022, 12, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7737), 0, false, "Transaction 35", new DateTime(2023, 9, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7738), 8, 1 },
                    { new Guid("3a2142c2-5558-424a-819f-9a350e8f38e1"), 670m, (byte)1, new DateTime(2023, 4, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7831), 0, true, "Transaction 53", new DateTime(2023, 9, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7833), 5, 0 },
                    { new Guid("3a4c30a8-953c-4ed5-9bf7-9e758311a6ab"), 842m, (byte)1, new DateTime(2023, 6, 13, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8152), 0, true, "Transaction 107", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8153), 3, 0 },
                    { new Guid("3b0eba88-5631-4e17-94c9-78c561203fcb"), 737m, (byte)1, new DateTime(2022, 12, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7632), 0, true, "Transaction 16", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7633), 9, 1 },
                    { new Guid("3ba07760-4c0a-4510-8170-a5f668204980"), 281m, (byte)1, new DateTime(2023, 4, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8530), 0, false, "Transaction 166", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8531), 1, 0 },
                    { new Guid("3bbea6dc-5f1e-4dfb-887a-581db2fc833c"), 785m, (byte)1, new DateTime(2023, 8, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7543), 0, false, "Transaction 8", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7544), 2, 1 },
                    { new Guid("3c3366d3-5b3d-4fb8-9547-462946b4c95b"), 96m, (byte)1, new DateTime(2022, 11, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7698), 0, false, "Transaction 28", new DateTime(2023, 8, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7700), 1, 0 },
                    { new Guid("3e218e2d-e8d2-4109-84fb-f4ea613f374d"), 494m, (byte)1, new DateTime(2023, 5, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8646), 0, false, "Transaction 188", new DateTime(2023, 9, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8648), 6, 0 },
                    { new Guid("405a9271-21de-4d7c-ac48-d26c7ca29ef5"), 882m, (byte)1, new DateTime(2023, 4, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8038), 0, false, "Transaction 86", new DateTime(2023, 9, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8040), 8, 1 },
                    { new Guid("417dbd70-a839-42c9-93d1-f76e8b53b158"), 422m, (byte)1, new DateTime(2023, 2, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8043), 0, true, "Transaction 87", new DateTime(2023, 9, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8045), 1, 0 },
                    { new Guid("46150e1e-f202-4902-99e1-e7b9083254b0"), 753m, (byte)1, new DateTime(2022, 11, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8066), 0, false, "Transaction 91", new DateTime(2023, 8, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8067), 9, 1 },
                    { new Guid("46d1b9d1-d77a-4a00-a464-c8383d67767d"), 224m, (byte)1, new DateTime(2022, 12, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8498), 0, true, "Transaction 160", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8499), 8, 1 },
                    { new Guid("494c06a2-9e5d-4290-809f-31aa67083d07"), 53m, (byte)1, new DateTime(2022, 11, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8694), 0, true, "Transaction 197", new DateTime(2023, 8, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8696), 5, 0 },
                    { new Guid("4a0a8838-3b03-40cb-b525-390f3d1840e1"), 678m, (byte)1, new DateTime(2023, 6, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7719), 0, true, "Transaction 32", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7721), 7, 1 },
                    { new Guid("4af306c3-dd85-4084-9053-46624bf4cbc9"), 458m, (byte)1, new DateTime(2022, 10, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8318), 0, false, "Transaction 132", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8319), 2, 0 },
                    { new Guid("4b392235-cc87-42dd-af3b-774213fd9e53"), 620m, (byte)1, new DateTime(2023, 6, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8610), 0, true, "Transaction 181", new DateTime(2023, 8, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8611), 6, 1 },
                    { new Guid("4b4187ec-787c-4265-9984-127e3537b59f"), 425m, (byte)1, new DateTime(2022, 10, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8593), 0, true, "Transaction 178", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8594), 2, 0 },
                    { new Guid("4c0d6e80-e9fc-400c-9cda-6d959bc2bb2f"), 797m, (byte)1, new DateTime(2023, 4, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8404), 0, false, "Transaction 148", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8406), 1, 0 },
                    { new Guid("4c25e191-0e38-4e6e-8724-48e97111fe35"), 587m, (byte)1, new DateTime(2022, 10, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8203), 0, false, "Transaction 111", new DateTime(2023, 9, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8205), 6, 0 },
                    { new Guid("4c3080d4-cb5b-42a2-bf31-73a6f18fa54a"), 254m, (byte)1, new DateTime(2023, 2, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8557), 0, true, "Transaction 171", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8559), 6, 0 },
                    { new Guid("4e645a04-c669-4a1f-937d-c40b37bfb19f"), 47m, (byte)1, new DateTime(2023, 1, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8525), 0, true, "Transaction 165", new DateTime(2023, 9, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8526), 1, 1 },
                    { new Guid("4ec12a12-b343-484a-a103-3678576150f0"), 849m, (byte)1, new DateTime(2023, 2, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8344), 0, false, "Transaction 137", new DateTime(2023, 8, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8345), 9, 0 },
                    { new Guid("4eddfcce-0e71-4baf-a170-723d1c6dcb5b"), 647m, (byte)1, new DateTime(2023, 3, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8651), 0, false, "Transaction 189", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8653), 7, 1 },
                    { new Guid("4f9c3237-b1f9-4e13-b042-a3419cd3e44a"), 32m, (byte)1, new DateTime(2023, 4, 13, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8284), 0, true, "Transaction 126", new DateTime(2023, 8, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8285), 5, 1 },
                    { new Guid("5122bfb4-505f-4e8a-a539-d49dd6721bbb"), 511m, (byte)1, new DateTime(2023, 1, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8377), 0, false, "Transaction 143", new DateTime(2023, 8, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8378), 9, 1 },
                    { new Guid("5145f918-8415-47d2-9ff5-88c3bd744be0"), 137m, (byte)1, new DateTime(2022, 12, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7538), 0, true, "Transaction 7", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7539), 2, 0 },
                    { new Guid("53dd8187-38fd-4eb8-9ca4-d96a466e1978"), 960m, (byte)1, new DateTime(2023, 6, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7762), 0, false, "Transaction 40", new DateTime(2023, 8, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7764), 7, 1 },
                    { new Guid("56302bea-349a-4924-b5f7-47da04f202e5"), 224m, (byte)1, new DateTime(2022, 10, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7963), 0, true, "Transaction 72", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7964), 7, 0 },
                    { new Guid("56ed957f-bdf0-43a7-813d-f34852af38db"), 851m, (byte)1, new DateTime(2023, 7, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8305), 0, false, "Transaction 130", new DateTime(2023, 8, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8307), 3, 1 },
                    { new Guid("5d7dc9fa-3c68-4eb9-b4b8-8a3345f1c0a3"), 572m, (byte)1, new DateTime(2022, 11, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7873), 0, false, "Transaction 61", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7875), 4, 0 },
                    { new Guid("5e58bd61-a0f9-4720-82a8-9a7de1c59159"), 909m, (byte)1, new DateTime(2023, 5, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7548), 0, false, "Transaction 9", new DateTime(2023, 8, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7549), 4, 1 },
                    { new Guid("5ee90a52-96ea-433f-a75e-214aea5777e3"), 187m, (byte)1, new DateTime(2023, 7, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8635), 0, false, "Transaction 186", new DateTime(2023, 9, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8636), 9, 1 },
                    { new Guid("5f7ae4cc-10f6-4624-a0ee-7e3d24e90d33"), 351m, (byte)1, new DateTime(2023, 5, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8710), 0, false, "Transaction 200", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8711), 6, 1 },
                    { new Guid("602f57f5-4953-4fa1-b243-3f5b8be3ab6e"), 444m, (byte)1, new DateTime(2023, 1, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8028), 0, false, "Transaction 84", new DateTime(2023, 9, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8030), 1, 1 },
                    { new Guid("608b092b-7b47-4c17-9ee5-6bfb61fad457"), 517m, (byte)1, new DateTime(2023, 2, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8656), 0, true, "Transaction 190", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8657), 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[,]
                {
                    { new Guid("614a14f2-e32c-4c6b-8e22-49fae4363a17"), 189m, (byte)1, new DateTime(2023, 7, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8208), 0, false, "Transaction 112", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8209), 8, 0 },
                    { new Guid("63c0d7bc-c8a3-4846-b09d-02ebebf75606"), 250m, (byte)1, new DateTime(2022, 12, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8545), 0, true, "Transaction 169", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8547), 3, 0 },
                    { new Guid("647e8d8b-5cc6-438f-bb65-140128c2371f"), 946m, (byte)1, new DateTime(2023, 7, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8245), 0, false, "Transaction 119", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8247), 3, 0 },
                    { new Guid("66406a55-3015-42ca-821e-4f374be045b5"), 707m, (byte)1, new DateTime(2023, 3, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8101), 0, false, "Transaction 98", new DateTime(2023, 8, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8103), 9, 0 },
                    { new Guid("670b2e5c-529e-4dcc-92c9-0fc062fbf2b2"), 934m, (byte)1, new DateTime(2023, 5, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8299), 0, true, "Transaction 129", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8300), 6, 0 },
                    { new Guid("6796e3ed-550d-46c6-91ca-02f3dcecbd8b"), 800m, (byte)1, new DateTime(2023, 2, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8225), 0, false, "Transaction 115", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8227), 1, 0 },
                    { new Guid("689cda42-cef5-47fa-9ea4-58f448791b16"), 132m, (byte)1, new DateTime(2023, 2, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8472), 0, false, "Transaction 155", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8474), 9, 0 },
                    { new Guid("6907a74d-dbbf-4615-8c0d-6f43ec496217"), 645m, (byte)1, new DateTime(2022, 12, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8261), 0, true, "Transaction 122", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8263), 8, 0 },
                    { new Guid("69f71f7c-bae4-4310-9b44-acd649a1c265"), 521m, (byte)1, new DateTime(2023, 8, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8124), 0, false, "Transaction 102", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8126), 9, 0 },
                    { new Guid("6b026c6e-60eb-49cb-a3e9-fe441f88f8be"), 393m, (byte)1, new DateTime(2023, 1, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8689), 0, false, "Transaction 196", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8690), 4, 1 },
                    { new Guid("6b11e1d9-1f0b-4732-8bc2-6a8c98f8f8de"), 51m, (byte)1, new DateTime(2023, 6, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7814), 0, false, "Transaction 50", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7816), 9, 0 },
                    { new Guid("6b8b67db-15d0-4d2c-b0a3-99a51ef73374"), 198m, (byte)1, new DateTime(2023, 3, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8399), 0, true, "Transaction 147", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8401), 8, 0 },
                    { new Guid("6dc4bbc7-1cd9-42f3-b8a8-57d49c987113"), 501m, (byte)1, new DateTime(2023, 3, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7693), 0, true, "Transaction 27", new DateTime(2023, 8, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7695), 1, 1 },
                    { new Guid("7135efb7-cc4e-4538-911f-5f6824334221"), 425m, (byte)1, new DateTime(2023, 1, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8600), 0, false, "Transaction 179", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8601), 8, 0 },
                    { new Guid("7179b3c0-a340-4f2b-841c-11e49511381b"), 894m, (byte)1, new DateTime(2023, 7, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8577), 0, true, "Transaction 175", new DateTime(2023, 9, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8579), 3, 1 },
                    { new Guid("724ae154-fe72-42fa-9732-9c3d2dbc9f47"), 331m, (byte)1, new DateTime(2023, 7, 14, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8312), 0, true, "Transaction 131", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8314), 4, 1 },
                    { new Guid("7373f925-fb29-48ad-9153-fd5f57b4bbe2"), 762m, (byte)1, new DateTime(2022, 11, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8514), 0, true, "Transaction 163", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8516), 1, 0 },
                    { new Guid("73d1849c-a26e-4a3d-a314-935e0ee84a43"), 12m, (byte)1, new DateTime(2022, 12, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7826), 0, true, "Transaction 52", new DateTime(2023, 8, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7828), 1, 1 },
                    { new Guid("74ea4010-a7e5-4ad3-b05a-d4b9da9d92c3"), 148m, (byte)1, new DateTime(2022, 11, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8129), 0, false, "Transaction 103", new DateTime(2023, 9, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8131), 5, 0 },
                    { new Guid("752e0efe-b301-4b47-bae8-3eebc96ad085"), 779m, (byte)1, new DateTime(2023, 5, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8629), 0, false, "Transaction 185", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8631), 8, 0 },
                    { new Guid("75936af5-074a-42f8-addf-a7ab129b7715"), 399m, (byte)1, new DateTime(2022, 11, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8289), 0, false, "Transaction 127", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8290), 5, 1 },
                    { new Guid("78329f7f-e40c-4dde-b2fb-390033a54424"), 519m, (byte)1, new DateTime(2023, 1, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8001), 0, false, "Transaction 79", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8002), 6, 0 },
                    { new Guid("78e9b75b-a57e-45db-a279-93b2f0af0cd7"), 580m, (byte)1, new DateTime(2023, 5, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8387), 0, true, "Transaction 145", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8389), 8, 0 },
                    { new Guid("78ee90e3-2dbd-438a-8cb5-d45850c0d065"), 988m, (byte)1, new DateTime(2023, 4, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8213), 0, true, "Transaction 113", new DateTime(2023, 8, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8215), 5, 1 },
                    { new Guid("79b7ee19-0a4a-4087-a843-2ee12c782459"), 822m, (byte)1, new DateTime(2023, 6, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7938), 0, true, "Transaction 67", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7939), 2, 1 },
                    { new Guid("7bae3e3c-5f2c-4c10-a5c6-ec57d34242a5"), 906m, (byte)1, new DateTime(2022, 11, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7676), 0, true, "Transaction 24", new DateTime(2023, 8, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7677), 8, 0 },
                    { new Guid("8030c89c-bb84-4158-b293-8d761359c9f0"), 809m, (byte)1, new DateTime(2023, 6, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7953), 0, true, "Transaction 70", new DateTime(2023, 9, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7954), 2, 1 },
                    { new Guid("80589fbe-abf5-43ea-a423-167aec17e718"), 817m, (byte)1, new DateTime(2023, 3, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7752), 0, true, "Transaction 38", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7754), 2, 0 },
                    { new Guid("83f15547-bf48-45d8-ab16-aa7c28704171"), 765m, (byte)1, new DateTime(2023, 7, 13, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7794), 0, false, "Transaction 46", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7796), 5, 0 },
                    { new Guid("8602c25d-e415-4437-a8ba-d38f7cb6abdb"), 594m, (byte)1, new DateTime(2023, 5, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8588), 0, true, "Transaction 177", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8589), 2, 0 },
                    { new Guid("88bbe0e9-f6b0-40d9-aaa6-3343a838cbc7"), 771m, (byte)1, new DateTime(2022, 12, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8620), 0, true, "Transaction 183", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8621), 4, 0 },
                    { new Guid("89a9a947-481f-4c9d-b836-627549104418"), 943m, (byte)1, new DateTime(2023, 5, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7704), 0, false, "Transaction 29", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7705), 8, 0 },
                    { new Guid("8be07c97-619c-4d6d-b3ba-e742bf09cb0a"), 347m, (byte)1, new DateTime(2023, 7, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8520), 0, true, "Transaction 164", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8521), 8, 1 },
                    { new Guid("8c6ac44b-25e4-44e6-ad58-fbb9531fa1bc"), 13m, (byte)1, new DateTime(2022, 12, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7525), 0, false, "Transaction 5", new DateTime(2023, 8, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7527), 7, 0 },
                    { new Guid("8d6e67e1-3dba-4443-8bc2-7bc0657ee617"), 878m, (byte)1, new DateTime(2023, 5, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7747), 0, true, "Transaction 37", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7749), 9, 1 },
                    { new Guid("8da48d17-18ee-4847-a891-52a3d82fe063"), 13m, (byte)1, new DateTime(2023, 3, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7836), 0, true, "Transaction 54", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7838), 9, 1 },
                    { new Guid("8e0e16e4-4bcb-472f-9a21-c510f0f97467"), 440m, (byte)1, new DateTime(2023, 4, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8677), 0, false, "Transaction 194", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8679), 7, 1 },
                    { new Guid("8e483b22-d2b4-47bd-b692-f4cfc4909ff6"), 443m, (byte)1, new DateTime(2023, 6, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8455), 0, true, "Transaction 152", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8457), 7, 1 },
                    { new Guid("8ed5c68a-a7c0-474a-91c3-f27c53461594"), 417m, (byte)1, new DateTime(2023, 3, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8661), 0, false, "Transaction 191", new DateTime(2023, 9, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8663), 5, 0 },
                    { new Guid("8fac3295-45d2-4bd1-8d2e-3457d05ddd86"), 223m, (byte)1, new DateTime(2023, 4, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8140), 0, true, "Transaction 105", new DateTime(2023, 8, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8141), 6, 1 },
                    { new Guid("9009cd0d-7364-4f2f-a6b0-efafcb02661c"), 863m, (byte)1, new DateTime(2023, 5, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7915), 0, true, "Transaction 63", new DateTime(2023, 8, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7916), 2, 1 },
                    { new Guid("9183220f-6eaa-4f7d-a5c1-02cd88bb443a"), 215m, (byte)1, new DateTime(2023, 6, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7637), 0, true, "Transaction 17", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7638), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[,]
                {
                    { new Guid("9387e3e9-a267-459a-8d6d-fab190ffd89f"), 299m, (byte)1, new DateTime(2023, 5, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7809), 0, true, "Transaction 49", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7811), 1, 0 },
                    { new Guid("9588aade-c289-47c2-a3f5-6e1e4b071328"), 243m, (byte)1, new DateTime(2023, 1, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8562), 0, true, "Transaction 172", new DateTime(2023, 9, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8564), 7, 1 },
                    { new Guid("988c3ff1-9bf2-4f43-955c-15181af15506"), 616m, (byte)1, new DateTime(2023, 5, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8328), 0, false, "Transaction 134", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8330), 1, 0 },
                    { new Guid("9bdf6c56-5f90-4e92-93b5-25685e07c8a9"), 653m, (byte)1, new DateTime(2023, 3, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8477), 0, true, "Transaction 156", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8479), 2, 0 },
                    { new Guid("9c5b35ba-9586-4667-abc4-0e6372fc3d0d"), 74m, (byte)1, new DateTime(2023, 7, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8625), 0, false, "Transaction 184", new DateTime(2023, 9, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8626), 2, 1 },
                    { new Guid("9c7383e9-8a1c-4746-ad36-0203a84b5a27"), 882m, (byte)1, new DateTime(2023, 8, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8134), 0, false, "Transaction 104", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8136), 9, 1 },
                    { new Guid("9c957925-655d-4b57-b3f9-10b9a8f41cf3"), 449m, (byte)1, new DateTime(2023, 2, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8567), 0, false, "Transaction 173", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8569), 6, 0 },
                    { new Guid("9ec98bbd-f8ca-4fa8-907e-e6f326b84cfe"), 613m, (byte)1, new DateTime(2022, 11, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8445), 0, true, "Transaction 150", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8446), 4, 0 },
                    { new Guid("9ef1b998-eeb2-4bb2-a944-b3051fcb33cb"), 880m, (byte)1, new DateTime(2023, 5, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7621), 0, true, "Transaction 14", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7623), 2, 1 },
                    { new Guid("a054b521-34ee-470d-92d5-9899611977b0"), 254m, (byte)1, new DateTime(2023, 7, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7562), 0, false, "Transaction 11", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7564), 4, 0 },
                    { new Guid("a147caae-e80c-4e32-9c38-79faf32457da"), 279m, (byte)1, new DateTime(2023, 4, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8382), 0, true, "Transaction 144", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8384), 1, 1 },
                    { new Guid("a45797d9-e237-4186-8db2-c2c6c104d1bf"), 383m, (byte)1, new DateTime(2023, 3, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8273), 0, true, "Transaction 124", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8275), 9, 0 },
                    { new Guid("a8d5b10b-9375-458e-b766-c6ee1a0a3f6d"), 256m, (byte)1, new DateTime(2023, 7, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7670), 0, true, "Transaction 23", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7672), 7, 0 },
                    { new Guid("a9b8afaf-192f-41bf-b9f8-3bb4d055d39c"), 332m, (byte)1, new DateTime(2023, 6, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8279), 0, true, "Transaction 125", new DateTime(2023, 8, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8280), 1, 1 },
                    { new Guid("aa4da6c3-3b5f-4f12-bbcf-6cc7034d7a79"), 729m, (byte)1, new DateTime(2023, 1, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8059), 0, false, "Transaction 90", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8060), 2, 1 },
                    { new Guid("abb04025-0dbf-4bf9-bbd0-ecbd56445b82"), 499m, (byte)1, new DateTime(2023, 1, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8582), 0, true, "Transaction 176", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8584), 4, 1 },
                    { new Guid("abd2a905-259d-4f0d-aa5f-f58c70146e03"), 169m, (byte)1, new DateTime(2023, 2, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8460), 0, true, "Transaction 153", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8462), 2, 1 },
                    { new Guid("adbd36a8-fb32-4e9c-bb5a-536d6a488ed9"), 52m, (byte)1, new DateTime(2023, 6, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7767), 0, true, "Transaction 41", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7769), 4, 0 },
                    { new Guid("ae303628-7e09-417b-a634-1ff96821d983"), 475m, (byte)1, new DateTime(2022, 12, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7841), 0, true, "Transaction 55", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7843), 8, 0 },
                    { new Guid("af71739f-1df1-4bb1-a661-31df0e2797cc"), 850m, (byte)1, new DateTime(2023, 6, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8550), 0, false, "Transaction 170", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8552), 3, 0 },
                    { new Guid("afb41561-0fde-49e6-af09-936f34cf9326"), 963m, (byte)1, new DateTime(2022, 12, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7804), 0, false, "Transaction 48", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7806), 3, 0 },
                    { new Guid("b0842fe2-9bd1-44cf-97c8-ca62e05f6c28"), 885m, (byte)1, new DateTime(2023, 2, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7846), 0, false, "Transaction 56", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7848), 9, 0 },
                    { new Guid("b131d03c-914d-453c-a716-7e437c9b567a"), 291m, (byte)1, new DateTime(2023, 7, 13, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8439), 0, true, "Transaction 149", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8441), 3, 0 },
                    { new Guid("b145ef14-d3b6-4ad3-a1d2-957ee11b0e31"), 92m, (byte)1, new DateTime(2023, 7, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7554), 0, false, "Transaction 10", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7556), 3, 0 },
                    { new Guid("b5600ab4-11ca-449b-9ef4-cbff42af866e"), 700m, (byte)1, new DateTime(2023, 1, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7968), 0, true, "Transaction 73", new DateTime(2023, 9, 10, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7969), 1, 1 },
                    { new Guid("b5ed918b-8ca3-4392-a45b-e287ddae3a1c"), 436m, (byte)1, new DateTime(2023, 8, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7742), 0, true, "Transaction 36", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7743), 3, 0 },
                    { new Guid("b6be889d-26ff-447e-9b26-6b19794ad883"), 586m, (byte)1, new DateTime(2023, 8, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8033), 0, true, "Transaction 85", new DateTime(2023, 8, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8035), 3, 0 },
                    { new Guid("bae20fb1-b8d4-4bef-b34c-4b00e81c889b"), 925m, (byte)1, new DateTime(2023, 4, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8198), 0, true, "Transaction 110", new DateTime(2023, 8, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8199), 6, 1 },
                    { new Guid("bc1866d5-18af-4b36-9f7b-ab7a5154278f"), 618m, (byte)1, new DateTime(2023, 2, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7868), 0, true, "Transaction 60", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7870), 6, 0 },
                    { new Guid("bd01ad60-ccef-4ed7-83de-fb5b4b17d2a8"), 558m, (byte)1, new DateTime(2023, 3, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8361), 0, false, "Transaction 140", new DateTime(2023, 9, 5, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8363), 3, 0 },
                    { new Guid("bd20998b-76d2-48a9-9fb7-00f1c631244e"), 276m, (byte)1, new DateTime(2023, 2, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8508), 0, true, "Transaction 162", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8509), 9, 0 },
                    { new Guid("bde00392-4d4c-4483-9f30-26061033fbd8"), 474m, (byte)1, new DateTime(2022, 12, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7643), 0, true, "Transaction 18", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7645), 3, 1 },
                    { new Guid("be095549-a54a-4f6a-89df-649066dae81e"), 125m, (byte)1, new DateTime(2022, 12, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8333), 0, false, "Transaction 135", new DateTime(2023, 8, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8335), 4, 0 },
                    { new Guid("c0040c51-b34c-4d5f-b505-f6aded33ce22"), 524m, (byte)1, new DateTime(2023, 5, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7973), 0, false, "Transaction 74", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7975), 3, 1 },
                    { new Guid("c03aabc6-4893-40c2-ad35-f68f0f814066"), 439m, (byte)1, new DateTime(2022, 12, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7851), 0, true, "Transaction 57", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7853), 9, 0 },
                    { new Guid("c0551ba2-5f96-49ee-8a5c-ed15bdfc5fc0"), 244m, (byte)1, new DateTime(2023, 2, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8450), 0, false, "Transaction 151", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8451), 1, 1 },
                    { new Guid("c05ba17f-abc7-43dd-b364-fdbfc07c958d"), 598m, (byte)1, new DateTime(2023, 2, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8323), 0, true, "Transaction 133", new DateTime(2023, 8, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8325), 5, 1 },
                    { new Guid("c117b413-9c29-47a1-8842-65e0d3dc5702"), 583m, (byte)1, new DateTime(2023, 1, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7986), 0, true, "Transaction 76", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7987), 5, 1 },
                    { new Guid("c3031406-cde4-4b9e-8616-54f89e71dd35"), 698m, (byte)1, new DateTime(2023, 1, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8356), 0, false, "Transaction 139", new DateTime(2023, 8, 21, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8358), 9, 0 },
                    { new Guid("c609744b-c86b-4436-b48e-b9fcabb43892"), 692m, (byte)1, new DateTime(2023, 4, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8487), 0, false, "Transaction 158", new DateTime(2023, 8, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8489), 3, 1 },
                    { new Guid("c659817b-f992-4311-a350-479edcf36031"), 794m, (byte)1, new DateTime(2023, 5, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7779), 0, true, "Transaction 43", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7781), 1, 0 },
                    { new Guid("c7faef8e-291e-4f12-930f-987828f6861e"), 920m, (byte)1, new DateTime(2023, 5, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8255), 0, true, "Transaction 121", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8257), 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BudgetId", "CreatedOn", "Currency", "IsReccuring", "Name", "ReccursOn", "TimesReccuring", "Type" },
                values: new object[,]
                {
                    { new Guid("ccac3f11-74d6-470e-8c32-7939be81c854"), 639m, (byte)1, new DateTime(2023, 4, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8294), 0, true, "Transaction 128", new DateTime(2023, 8, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8295), 5, 1 },
                    { new Guid("cd280775-ca40-41d3-853d-a6095308d086"), 826m, (byte)1, new DateTime(2023, 3, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8503), 0, true, "Transaction 161", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8504), 8, 0 },
                    { new Guid("ce0c6656-ee45-459e-b6ea-e31fb8f3aeee"), 187m, (byte)1, new DateTime(2023, 3, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7920), 0, true, "Transaction 64", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7921), 2, 0 },
                    { new Guid("ce4ef12e-30d1-4005-8ad7-7bade517aa3a"), 673m, (byte)1, new DateTime(2023, 4, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8699), 0, true, "Transaction 198", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8701), 8, 1 },
                    { new Guid("d1f2bb32-f742-4636-ac7e-7ab90647b785"), 644m, (byte)1, new DateTime(2023, 5, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8240), 0, false, "Transaction 118", new DateTime(2023, 9, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8242), 8, 0 },
                    { new Guid("d2415f4d-d98f-4fc5-9432-3e648aa918f3"), 342m, (byte)1, new DateTime(2023, 5, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7660), 0, false, "Transaction 21", new DateTime(2023, 9, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7662), 4, 0 },
                    { new Guid("d4b9961d-1002-447c-b5ce-94b279328133"), 644m, (byte)1, new DateTime(2022, 12, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8482), 0, false, "Transaction 157", new DateTime(2023, 8, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8484), 5, 1 },
                    { new Guid("d81ad1b1-0cab-48bc-b9c1-e988dd3eca45"), 316m, (byte)1, new DateTime(2023, 4, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8081), 0, true, "Transaction 94", new DateTime(2023, 8, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8082), 3, 1 },
                    { new Guid("d9f708f1-436c-4c1b-ad96-80ff6448ce57"), 37m, (byte)1, new DateTime(2022, 11, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8671), 0, false, "Transaction 193", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8673), 1, 0 },
                    { new Guid("dbf3ad1a-a9a7-42cf-a8ef-5d3b81730392"), 874m, (byte)1, new DateTime(2022, 12, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8119), 0, false, "Transaction 101", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8121), 1, 1 },
                    { new Guid("dea9c765-b41e-47d6-a96c-8bc8cf236f89"), 277m, (byte)1, new DateTime(2023, 1, 2, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7757), 0, false, "Transaction 39", new DateTime(2023, 8, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7759), 1, 0 },
                    { new Guid("dfebea0a-1f6e-42b5-98fb-1d6127a92562"), 505m, (byte)1, new DateTime(2023, 6, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8392), 0, true, "Transaction 146", new DateTime(2023, 8, 31, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8394), 9, 1 },
                    { new Guid("e0c006dc-a806-4254-8fdb-55ae68c9d413"), 86m, (byte)1, new DateTime(2023, 2, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7784), 0, false, "Transaction 44", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7786), 3, 1 },
                    { new Guid("e3ee51e9-d6e6-445a-848f-9648ed4e7d27"), 859m, (byte)1, new DateTime(2023, 2, 22, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8605), 0, false, "Transaction 180", new DateTime(2023, 8, 29, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8606), 1, 1 },
                    { new Guid("e64b4f73-46b2-447f-9a2c-10d5c28dff19"), 834m, (byte)1, new DateTime(2022, 12, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7709), 0, false, "Transaction 30", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7710), 9, 1 },
                    { new Guid("e6967670-70fa-4519-974c-212127956ecd"), 412m, (byte)1, new DateTime(2023, 5, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7681), 0, false, "Transaction 25", new DateTime(2023, 9, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7682), 4, 1 },
                    { new Guid("e8910976-c47a-4747-87b7-711bc3adaa09"), 888m, (byte)1, new DateTime(2023, 7, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8076), 0, false, "Transaction 93", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8077), 6, 0 },
                    { new Guid("e8968e07-d7d2-444e-adf8-8505e12c5b75"), 239m, (byte)1, new DateTime(2023, 6, 8, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8367), 0, false, "Transaction 141", new DateTime(2023, 8, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8368), 4, 1 },
                    { new Guid("ef64abd0-7fac-44f9-ae07-b0b9d74d6445"), 523m, (byte)1, new DateTime(2023, 8, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7909), 0, false, "Transaction 62", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7911), 9, 0 },
                    { new Guid("f1277963-0c42-413b-8da8-c00814fd0bcc"), 357m, (byte)1, new DateTime(2022, 10, 25, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7686), 0, true, "Transaction 26", new DateTime(2023, 8, 24, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7688), 7, 0 },
                    { new Guid("f161bb50-9721-4ad1-bd42-ad2abb992461"), 5m, (byte)1, new DateTime(2023, 5, 23, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7856), 0, true, "Transaction 58", new DateTime(2023, 9, 6, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7858), 4, 1 },
                    { new Guid("f2475e0a-2cd6-4f10-9182-928f6b306f7b"), 270m, (byte)1, new DateTime(2022, 12, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8230), 0, false, "Transaction 116", new DateTime(2023, 8, 26, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8232), 7, 0 },
                    { new Guid("f377585c-ac70-4471-9495-0628823c880c"), 808m, (byte)1, new DateTime(2023, 4, 16, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8071), 0, false, "Transaction 92", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8072), 4, 1 },
                    { new Guid("f4044184-b43e-4777-8980-b01ede6e5900"), 837m, (byte)1, new DateTime(2023, 2, 15, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7821), 0, true, "Transaction 51", new DateTime(2023, 9, 4, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7823), 5, 1 },
                    { new Guid("f4d6144f-1162-41a5-b20c-49335ab53689"), 518m, (byte)1, new DateTime(2023, 7, 27, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7948), 0, true, "Transaction 69", new DateTime(2023, 8, 20, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7949), 8, 0 },
                    { new Guid("f52e9c16-da04-462b-b6f3-d9a95692221a"), 797m, (byte)1, new DateTime(2023, 3, 7, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8218), 0, true, "Transaction 114", new DateTime(2023, 8, 28, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8220), 8, 0 },
                    { new Guid("f8207208-5135-4eb5-8bb2-b27c4cc550b1"), 987m, (byte)1, new DateTime(2023, 5, 18, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8016), 0, true, "Transaction 82", new DateTime(2023, 9, 3, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8018), 2, 1 },
                    { new Guid("f9b7d38c-a946-4b2e-9066-5042bbf702bd"), 565m, (byte)1, new DateTime(2023, 4, 12, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8157), 0, true, "Transaction 108", new DateTime(2023, 9, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8158), 3, 1 },
                    { new Guid("fbd1c22f-753f-42a7-949e-d5084bcd72a0"), 704m, (byte)1, new DateTime(2023, 5, 9, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7991), 0, false, "Transaction 77", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7992), 6, 0 },
                    { new Guid("fcd6110b-39d1-4f60-b811-c1dd6e0e6fa3"), 905m, (byte)1, new DateTime(2023, 1, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8054), 0, true, "Transaction 89", new DateTime(2023, 9, 1, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8055), 5, 0 },
                    { new Guid("fd31f452-f76a-4a0f-9e47-e17177dc7766"), 795m, (byte)1, new DateTime(2023, 4, 19, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8096), 0, true, "Transaction 97", new DateTime(2023, 8, 30, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(8098), 5, 1 },
                    { new Guid("fe5a513f-7629-428c-9b76-fc7604283ec7"), 413m, (byte)1, new DateTime(2023, 5, 11, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7943), 0, true, "Transaction 68", new DateTime(2023, 8, 17, 20, 6, 37, 811, DateTimeKind.Local).AddTicks(7944), 3, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00a9781e-b60d-40c3-9b93-f79d25808644"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("032ee56d-28b7-4b51-aa29-c5db1190e2e6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("03c3e2cd-7566-4584-a280-4389f10003ae"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("04e59fe5-9de9-4c63-aa21-085687ef1d6c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("04fc722d-9749-461f-a765-c8651b46281e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0535dba6-1054-4e2d-b5b3-44b0f709f4f8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0611c58f-3c72-4131-96f8-3173daaa3083"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0751c5ac-99a2-44f9-95c6-45e04ded9e94"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("084a7b6a-b53d-469c-b5ce-de91652220f0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("08d0eb94-0e70-4f83-83d3-d619e32a73e8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0c30875b-b892-47c9-84c4-b2aa3b89dfbf"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("100cef6b-60d3-40da-80a2-fa4527529408"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("11ca8bb0-c6f6-4b15-a270-75a582a3f27b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("12488586-a2da-45ff-8a6a-72541bd69df2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1436d1e0-54fc-471c-980c-2d168909c348"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("14ac0262-aa91-4408-9274-3f6830cbae9c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1629561e-70bf-4c51-984b-fe8174491ba3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("168c7be3-70cc-4217-98b0-b9aef5c973cd"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("173ed9c7-f2d2-4951-b16d-85e71736c7ea"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("17d888aa-6057-4543-8d6d-e31d6d5707f9"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1899f703-6b08-49ed-b4cf-52fa35ed23e8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("18a265b1-b344-4614-84be-89dea701dc36"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1907922e-c650-42ee-9cb2-23124fad2fbe"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1c680dbd-c85a-4299-aff8-380dcf955653"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1de712a4-63c4-499d-b126-e439749e51f6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1df12d37-923d-4a17-9759-b580b33a15cd"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1f37045b-b2fb-4f3a-a09b-84547c2c0f9f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("1f71b242-0985-4267-9ed7-421aa092c761"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("207c141f-3f95-42eb-85cd-504e506bb341"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2082037b-738e-4eb6-934c-12f110fc5c43"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("221977c8-2c27-4859-aeb7-068617127191"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("22c4fd40-057a-4c70-a7f9-5e0156d0d5c5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("232f1848-f926-4650-b1f4-7d1ca2ecb296"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("245dd991-1b91-4494-be64-90b34ba9860d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("25d8e9bd-8110-4925-9617-e0f34c351bd7"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("26fd41f7-2935-4f43-b030-e5255f65cf63"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("276c9053-9c22-4690-96ad-a5ac13e57fdd"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2ae11fbd-26e7-4a5f-9b91-f0a5b30d325b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2b6c32cc-e3ad-459a-8db2-569bbb0bc3cd"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2b9bec2f-dc7e-4ce6-ae38-22120321fa76"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2da5ee59-a7f2-4c29-80c2-2401cafc2bb2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2fe4dc0e-9fe1-4f89-bdc3-bf324951a5e6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("332a6b19-bb86-4214-b33c-c16a3b381295"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3347b728-6ab3-4a18-9186-22d09d9c4588"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("345647c9-107f-4209-9203-a52df5742c3e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("358c5ca6-3284-4a4a-a538-3423dcb1f37a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("35ba9de0-4d86-4b33-a544-e4b4fd48f2f0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("360fb402-1a72-4d45-9f92-0ec71fe9d560"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("364f4e18-7943-44ed-af4f-aa989e3739c9"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3972ebaa-d28c-46a8-9b9e-742519baecb9"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3a2142c2-5558-424a-819f-9a350e8f38e1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3a4c30a8-953c-4ed5-9bf7-9e758311a6ab"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3b0eba88-5631-4e17-94c9-78c561203fcb"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3ba07760-4c0a-4510-8170-a5f668204980"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3bbea6dc-5f1e-4dfb-887a-581db2fc833c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3c3366d3-5b3d-4fb8-9547-462946b4c95b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3e218e2d-e8d2-4109-84fb-f4ea613f374d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("405a9271-21de-4d7c-ac48-d26c7ca29ef5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("417dbd70-a839-42c9-93d1-f76e8b53b158"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("46150e1e-f202-4902-99e1-e7b9083254b0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("46d1b9d1-d77a-4a00-a464-c8383d67767d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("494c06a2-9e5d-4290-809f-31aa67083d07"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4a0a8838-3b03-40cb-b525-390f3d1840e1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4af306c3-dd85-4084-9053-46624bf4cbc9"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4b392235-cc87-42dd-af3b-774213fd9e53"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4b4187ec-787c-4265-9984-127e3537b59f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4c0d6e80-e9fc-400c-9cda-6d959bc2bb2f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4c25e191-0e38-4e6e-8724-48e97111fe35"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4c3080d4-cb5b-42a2-bf31-73a6f18fa54a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4e645a04-c669-4a1f-937d-c40b37bfb19f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4ec12a12-b343-484a-a103-3678576150f0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4eddfcce-0e71-4baf-a170-723d1c6dcb5b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4f9c3237-b1f9-4e13-b042-a3419cd3e44a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("5122bfb4-505f-4e8a-a539-d49dd6721bbb"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("5145f918-8415-47d2-9ff5-88c3bd744be0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("53dd8187-38fd-4eb8-9ca4-d96a466e1978"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("56302bea-349a-4924-b5f7-47da04f202e5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("56ed957f-bdf0-43a7-813d-f34852af38db"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("5d7dc9fa-3c68-4eb9-b4b8-8a3345f1c0a3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("5e58bd61-a0f9-4720-82a8-9a7de1c59159"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("5ee90a52-96ea-433f-a75e-214aea5777e3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("5f7ae4cc-10f6-4624-a0ee-7e3d24e90d33"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("602f57f5-4953-4fa1-b243-3f5b8be3ab6e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("608b092b-7b47-4c17-9ee5-6bfb61fad457"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("614a14f2-e32c-4c6b-8e22-49fae4363a17"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("63c0d7bc-c8a3-4846-b09d-02ebebf75606"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("647e8d8b-5cc6-438f-bb65-140128c2371f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("66406a55-3015-42ca-821e-4f374be045b5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("670b2e5c-529e-4dcc-92c9-0fc062fbf2b2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6796e3ed-550d-46c6-91ca-02f3dcecbd8b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("689cda42-cef5-47fa-9ea4-58f448791b16"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6907a74d-dbbf-4615-8c0d-6f43ec496217"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("69f71f7c-bae4-4310-9b44-acd649a1c265"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6b026c6e-60eb-49cb-a3e9-fe441f88f8be"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6b11e1d9-1f0b-4732-8bc2-6a8c98f8f8de"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6b8b67db-15d0-4d2c-b0a3-99a51ef73374"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6dc4bbc7-1cd9-42f3-b8a8-57d49c987113"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7135efb7-cc4e-4538-911f-5f6824334221"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7179b3c0-a340-4f2b-841c-11e49511381b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("724ae154-fe72-42fa-9732-9c3d2dbc9f47"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7373f925-fb29-48ad-9153-fd5f57b4bbe2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("73d1849c-a26e-4a3d-a314-935e0ee84a43"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("74ea4010-a7e5-4ad3-b05a-d4b9da9d92c3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("752e0efe-b301-4b47-bae8-3eebc96ad085"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("75936af5-074a-42f8-addf-a7ab129b7715"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("78329f7f-e40c-4dde-b2fb-390033a54424"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("78e9b75b-a57e-45db-a279-93b2f0af0cd7"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("78ee90e3-2dbd-438a-8cb5-d45850c0d065"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("79b7ee19-0a4a-4087-a843-2ee12c782459"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7bae3e3c-5f2c-4c10-a5c6-ec57d34242a5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8030c89c-bb84-4158-b293-8d761359c9f0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("80589fbe-abf5-43ea-a423-167aec17e718"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("83f15547-bf48-45d8-ab16-aa7c28704171"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8602c25d-e415-4437-a8ba-d38f7cb6abdb"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("88bbe0e9-f6b0-40d9-aaa6-3343a838cbc7"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("89a9a947-481f-4c9d-b836-627549104418"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8be07c97-619c-4d6d-b3ba-e742bf09cb0a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8c6ac44b-25e4-44e6-ad58-fbb9531fa1bc"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8d6e67e1-3dba-4443-8bc2-7bc0657ee617"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8da48d17-18ee-4847-a891-52a3d82fe063"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8e0e16e4-4bcb-472f-9a21-c510f0f97467"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8e483b22-d2b4-47bd-b692-f4cfc4909ff6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8ed5c68a-a7c0-474a-91c3-f27c53461594"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("8fac3295-45d2-4bd1-8d2e-3457d05ddd86"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9009cd0d-7364-4f2f-a6b0-efafcb02661c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9183220f-6eaa-4f7d-a5c1-02cd88bb443a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9387e3e9-a267-459a-8d6d-fab190ffd89f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9588aade-c289-47c2-a3f5-6e1e4b071328"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("988c3ff1-9bf2-4f43-955c-15181af15506"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9bdf6c56-5f90-4e92-93b5-25685e07c8a9"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9c5b35ba-9586-4667-abc4-0e6372fc3d0d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9c7383e9-8a1c-4746-ad36-0203a84b5a27"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9c957925-655d-4b57-b3f9-10b9a8f41cf3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9ec98bbd-f8ca-4fa8-907e-e6f326b84cfe"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9ef1b998-eeb2-4bb2-a944-b3051fcb33cb"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a054b521-34ee-470d-92d5-9899611977b0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a147caae-e80c-4e32-9c38-79faf32457da"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a45797d9-e237-4186-8db2-c2c6c104d1bf"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a8d5b10b-9375-458e-b766-c6ee1a0a3f6d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a9b8afaf-192f-41bf-b9f8-3bb4d055d39c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("aa4da6c3-3b5f-4f12-bbcf-6cc7034d7a79"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("abb04025-0dbf-4bf9-bbd0-ecbd56445b82"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("abd2a905-259d-4f0d-aa5f-f58c70146e03"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("adbd36a8-fb32-4e9c-bb5a-536d6a488ed9"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ae303628-7e09-417b-a634-1ff96821d983"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("af71739f-1df1-4bb1-a661-31df0e2797cc"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("afb41561-0fde-49e6-af09-936f34cf9326"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b0842fe2-9bd1-44cf-97c8-ca62e05f6c28"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b131d03c-914d-453c-a716-7e437c9b567a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b145ef14-d3b6-4ad3-a1d2-957ee11b0e31"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b5600ab4-11ca-449b-9ef4-cbff42af866e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b5ed918b-8ca3-4392-a45b-e287ddae3a1c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b6be889d-26ff-447e-9b26-6b19794ad883"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bae20fb1-b8d4-4bef-b34c-4b00e81c889b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bc1866d5-18af-4b36-9f7b-ab7a5154278f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bd01ad60-ccef-4ed7-83de-fb5b4b17d2a8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bd20998b-76d2-48a9-9fb7-00f1c631244e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bde00392-4d4c-4483-9f30-26061033fbd8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("be095549-a54a-4f6a-89df-649066dae81e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c0040c51-b34c-4d5f-b505-f6aded33ce22"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c03aabc6-4893-40c2-ad35-f68f0f814066"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c0551ba2-5f96-49ee-8a5c-ed15bdfc5fc0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c05ba17f-abc7-43dd-b364-fdbfc07c958d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c117b413-9c29-47a1-8842-65e0d3dc5702"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c3031406-cde4-4b9e-8616-54f89e71dd35"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c609744b-c86b-4436-b48e-b9fcabb43892"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c659817b-f992-4311-a350-479edcf36031"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c7faef8e-291e-4f12-930f-987828f6861e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ccac3f11-74d6-470e-8c32-7939be81c854"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("cd280775-ca40-41d3-853d-a6095308d086"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ce0c6656-ee45-459e-b6ea-e31fb8f3aeee"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ce4ef12e-30d1-4005-8ad7-7bade517aa3a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d1f2bb32-f742-4636-ac7e-7ab90647b785"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d2415f4d-d98f-4fc5-9432-3e648aa918f3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d4b9961d-1002-447c-b5ce-94b279328133"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d81ad1b1-0cab-48bc-b9c1-e988dd3eca45"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d9f708f1-436c-4c1b-ad96-80ff6448ce57"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("dbf3ad1a-a9a7-42cf-a8ef-5d3b81730392"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("dea9c765-b41e-47d6-a96c-8bc8cf236f89"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("dfebea0a-1f6e-42b5-98fb-1d6127a92562"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e0c006dc-a806-4254-8fdb-55ae68c9d413"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e3ee51e9-d6e6-445a-848f-9648ed4e7d27"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e64b4f73-46b2-447f-9a2c-10d5c28dff19"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e6967670-70fa-4519-974c-212127956ecd"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e8910976-c47a-4747-87b7-711bc3adaa09"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e8968e07-d7d2-444e-adf8-8505e12c5b75"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ef64abd0-7fac-44f9-ae07-b0b9d74d6445"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f1277963-0c42-413b-8da8-c00814fd0bcc"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f161bb50-9721-4ad1-bd42-ad2abb992461"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f2475e0a-2cd6-4f10-9182-928f6b306f7b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f377585c-ac70-4471-9495-0628823c880c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f4044184-b43e-4777-8980-b01ede6e5900"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f4d6144f-1162-41a5-b20c-49335ab53689"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f52e9c16-da04-462b-b6f3-d9a95692221a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f8207208-5135-4eb5-8bb2-b27c4cc550b1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f9b7d38c-a946-4b2e-9066-5042bbf702bd"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("fbd1c22f-753f-42a7-949e-d5084bcd72a0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("fcd6110b-39d1-4f60-b811-c1dd6e0e6fa3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("fd31f452-f76a-4a0f-9e47-e17177dc7766"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("fe5a513f-7629-428c-9b76-fc7604283ec7"));

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
    }
}
