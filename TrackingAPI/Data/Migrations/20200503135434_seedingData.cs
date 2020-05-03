using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingAPI.Data.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Cost", "Title" },
                values: new object[] { 1, 25f, "Shingles" });

            migrationBuilder.InsertData(
                table: "HoursSpent",
                columns: new[] { "Id", "Hours", "Name" },
                values: new object[] { 1, 5f, "Jacob" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "This one is good", "New Note" },
                    { 2, "This is good too", "Receipt Note" }
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "Store", "Total" },
                values: new object[] { 1, "Menards", 100f });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "BudgetUsed", "ExpenseId", "HoursSpentId", "Mileage", "NoteId", "ReceiptId", "Title" },
                values: new object[] { 1, 5000f, 1300f, 1, 1, 45f, 1, 1, "Roof" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HoursSpent",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receipts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
