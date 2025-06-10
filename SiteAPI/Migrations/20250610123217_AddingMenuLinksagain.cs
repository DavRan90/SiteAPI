﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingMenuLinksagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Elements");

            migrationBuilder.DropColumn(
                name: "MenuLink",
                table: "Elements");

            migrationBuilder.DropColumn(
                name: "NumberOfTitles",
                table: "Elements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Elements",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MenuLink",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTitles",
                table: "Elements",
                type: "int",
                nullable: true);
        }
    }
}
