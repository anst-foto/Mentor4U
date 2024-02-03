using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor4U.WpfClassic.Migrations
{
    /// <inheritdoc />
    public partial class Scill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Scill",
                table: "MentorsTable",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scill",
                table: "MentorsTable");
        }
    }
}
