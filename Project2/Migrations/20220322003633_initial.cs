using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.TimeSlotId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    GroupId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Responses_Times_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "Times",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeSlotId", "Available", "Date", "Time" },
                values: new object[] { 1, true, "04/01/22", "9" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "GroupId", "Email", "GroupName", "GroupSize", "Phone", "TimeSlotId" },
                values: new object[] { 1L, "test@test.com", "Test Group", "10", "8011234567", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_TimeSlotId",
                table: "Responses",
                column: "TimeSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
