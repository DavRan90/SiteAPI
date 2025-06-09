using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedFontProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FontColorString",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FontFamilyString",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FontColorString",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "FontFamilyString",
                table: "Sites");
        }
    }
}
