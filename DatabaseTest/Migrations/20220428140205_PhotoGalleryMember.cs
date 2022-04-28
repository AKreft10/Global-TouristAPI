using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTest.Migrations
{
    public partial class PhotoGalleryMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GalleryMember",
                table: "Photos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryMember",
                table: "Photos");
        }
    }
}
