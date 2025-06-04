using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteAPI.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Elements");

            migrationBuilder.AddColumn<int>(
                name: "ElementType",
                table: "Elements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementType",
                table: "Elements");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Elements",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }
    }
}
