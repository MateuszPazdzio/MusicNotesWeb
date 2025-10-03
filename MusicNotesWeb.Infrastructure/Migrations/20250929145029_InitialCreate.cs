using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicNotesWeb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoteAttempts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDetailsId = table.Column<int>(type: "int", nullable: false),
                    ExpectedNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OctaveNr = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteAttempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteAttempts_GameDetails_GameDetailsId",
                        column: x => x.GameDetailsId,
                        principalTable: "GameDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NoteAttempts_GameDetailsId",
                table: "NoteAttempts",
                column: "GameDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoteAttempts");

            migrationBuilder.DropTable(
                name: "GameDetails");
        }
    }
}
