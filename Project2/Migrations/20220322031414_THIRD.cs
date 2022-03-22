using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class THIRD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 1,
                column: "Time",
                value: "8 AM");

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 2,
                columns: new[] { "Available", "Date", "Time" },
                values: new object[] { true, "04/01/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 90, true, "04/07/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 67, true, "04/06/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 66, true, "04/06/22", "8 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 65, true, "04/05/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 64, true, "04/05/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 63, true, "04/05/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 62, true, "04/05/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 61, true, "04/05/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 60, true, "04/05/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 68, true, "04/06/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 59, true, "04/05/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 57, true, "04/05/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 56, true, "04/05/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 55, true, "04/05/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 54, true, "04/05/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 53, true, "04/05/22", "8 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 52, true, "04/04/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 51, true, "04/04/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 50, true, "04/04/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 58, true, "04/05/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 91, true, "04/07/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 69, true, "04/06/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 71, true, "04/06/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 89, true, "04/07/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 88, true, "04/07/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 87, true, "04/07/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 86, true, "04/07/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 85, true, "04/07/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 84, true, "04/07/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 83, true, "04/07/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 82, true, "04/07/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 49, true, "04/04/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 81, true, "04/07/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 79, true, "04/07/22", "8 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 78, true, "04/06/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 77, true, "04/06/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 76, true, "04/06/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 75, true, "04/06/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 74, true, "04/06/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 73, true, "04/06/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 72, true, "04/06/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 80, true, "04/07/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 70, true, "04/06/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 48, true, "04/04/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 46, true, "04/04/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 22, true, "04/02/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 21, true, "04/02/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 20, true, "04/02/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 19, true, "04/02/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 18, true, "04/02/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 17, true, "04/02/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 16, true, "04/02/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 15, true, "04/02/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 14, true, "04/02/22", "8 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 13, true, "04/01/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 12, true, "04/01/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 11, true, "04/01/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 10, true, "04/01/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 9, true, "04/01/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 8, true, "04/01/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 7, true, "04/01/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 6, true, "04/01/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 5, true, "04/01/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 4, true, "04/01/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 23, true, "04/02/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 47, true, "04/04/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 24, true, "04/02/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 26, true, "04/02/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 45, true, "04/04/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 44, true, "04/04/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 43, true, "04/04/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 42, true, "04/04/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 41, true, "04/04/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 40, true, "04/04/22", "8 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 39, true, "04/03/22", "8 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 38, true, "04/03/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 37, true, "04/03/22", "6 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 36, true, "04/03/22", "5 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 35, true, "04/03/22", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 34, true, "04/03/22", "3 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 33, true, "04/03/22", "2 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 32, true, "04/03/22", "1 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 31, true, "04/03/22", "12 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 30, true, "04/03/22", "11 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 29, true, "04/03/22", "10 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 28, true, "04/03/22", "9 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 27, true, "04/03/22", "8 AM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 25, true, "04/02/22", "7 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 3, true, "04/01/22", "10 AM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 91);

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 1,
                column: "Time",
                value: "9 AM");

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimeSlotId",
                keyValue: 2,
                columns: new[] { "Available", "Date", "Time" },
                values: new object[] { false, "12/01/22", "10 AM" });
        }
    }
}
