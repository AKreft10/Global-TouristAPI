using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTest.Migrations
{
    public partial class ThumbnailPhotoProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailPhoto",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailPhoto",
                table: "Accommodations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailPhoto",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "ThumbnailPhoto",
                table: "Accommodations");
        }
    }
}
