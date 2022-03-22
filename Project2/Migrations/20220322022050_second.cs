using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 1,
                column: "Time",
                value: "9 AM");

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 2, false, "12/01/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Email", "GroupName", "GroupSize", "Phone", "TimeSlotId" },
                values: new object[] { 2L, "test@test.com", "Test Group", "10", "8011234567", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 1,
                column: "Time",
                value: "9");
        }
    }
}
