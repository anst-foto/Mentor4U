using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor4U.WpfClassic.Migrations
{
    /// <inheritdoc />
    public partial class rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scills_Mentors_MentorId",
                table: "Scills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scills",
                table: "Scills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentors",
                table: "Mentors");

            migrationBuilder.RenameTable(
                name: "Scills",
                newName: "ScillTable");

            migrationBuilder.RenameTable(
                name: "Mentors",
                newName: "MentorsTable");

            migrationBuilder.RenameIndex(
                name: "IX_Scills_MentorId",
                table: "ScillTable",
                newName: "IX_ScillTable_MentorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScillTable",
                table: "ScillTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MentorsTable",
                table: "MentorsTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScillTable_MentorsTable_MentorId",
                table: "ScillTable",
                column: "MentorId",
                principalTable: "MentorsTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScillTable_MentorsTable_MentorId",
                table: "ScillTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScillTable",
                table: "ScillTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MentorsTable",
                table: "MentorsTable");

            migrationBuilder.RenameTable(
                name: "ScillTable",
                newName: "Scills");

            migrationBuilder.RenameTable(
                name: "MentorsTable",
                newName: "Mentors");

            migrationBuilder.RenameIndex(
                name: "IX_ScillTable_MentorId",
                table: "Scills",
                newName: "IX_Scills_MentorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scills",
                table: "Scills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentors",
                table: "Mentors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scills_Mentors_MentorId",
                table: "Scills",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
