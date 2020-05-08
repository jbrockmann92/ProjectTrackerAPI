using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingAPI.Migrations
{
    public partial class SeedingMoreDataForLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Cost", "ProjectId", "Title" },
                values: new object[] { 2, 125f, 1, "Nail Gun" });

            migrationBuilder.InsertData(
                table: "HoursSpent",
                columns: new[] { "Id", "Hours", "Name", "ProjectId" },
                values: new object[] { 2, 15f, "Joey", 1 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "BudgetUsed", "Mileage", "Title" },
                values: new object[] { 2, 3500f, 2200f, 134f, "Janesville House" });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Cost", "ProjectId", "Title" },
                values: new object[] { 3, 25f, 2, "Underlayment" });

            migrationBuilder.InsertData(
                table: "HoursSpent",
                columns: new[] { "Id", "Hours", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 3, 5f, "Fleck", 2 },
                    { 4, 15f, "Caleb", 2 }
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "ProjectId", "Store", "Total" },
                values: new object[] { 2, 2, "Menards", 50f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HoursSpent",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HoursSpent",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HoursSpent",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Receipts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
