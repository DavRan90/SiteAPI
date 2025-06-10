using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedMenuLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuLinks",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuLinks",
                table: "Elements");
        }
    }
}
