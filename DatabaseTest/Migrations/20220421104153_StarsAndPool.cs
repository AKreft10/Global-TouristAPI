using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTest.Migrations
{
    public partial class StarsAndPool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasPool",
                table: "Accommodations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Accommodations",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasPool",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Accommodations");
        }
    }
}
