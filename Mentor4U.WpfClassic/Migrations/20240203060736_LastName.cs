using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mentor4U.WpfClassic.Migrations
{
    /// <inheritdoc />
    public partial class LastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScillTable");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "MentorsTable",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "MentorsTable");

            migrationBuilder.CreateTable(
                name: "ScillTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MentorId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScillTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScillTable_MentorsTable_MentorId",
                        column: x => x.MentorId,
                        principalTable: "MentorsTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScillTable_MentorId",
                table: "ScillTable",
                column: "MentorId");
        }
    }
}
