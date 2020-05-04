using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingAPI.Migrations
{
    public partial class seedingMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Cost", "ProjectId", "Title" },
                values: new object[] { 1, 25f, 1, "Shingles" });

            migrationBuilder.InsertData(
                table: "HoursSpent",
                columns: new[] { "Id", "Hours", "Name", "ProjectId" },
                values: new object[] { 1, 5f, "Jacob", 1 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "ProjectId", "Text", "Title" },
                values: new object[,]
                {
                    { 1, 1, "This one is good", "New Note" },
                    { 2, 1, "This is good too", "Receipt Note" }
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "ProjectId", "Store", "Total" },
                values: new object[] { 1, 1, "Menards", 100f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Receipts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
