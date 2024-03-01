using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtgServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Commander = table.Column<string>(type: "TEXT", nullable: true),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deck_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WinnerId = table.Column<int>(type: "INTEGER", nullable: true),
                    Player2Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Player3Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Player4Id = table.Column<int>(type: "INTEGER", nullable: true),
                    WinningDeckId = table.Column<int>(type: "INTEGER", nullable: true),
                    Deck2Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Deck3Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Deck4Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Deck_Deck2Id",
                        column: x => x.Deck2Id,
                        principalTable: "Deck",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Deck_Deck3Id",
                        column: x => x.Deck3Id,
                        principalTable: "Deck",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Deck_Deck4Id",
                        column: x => x.Deck4Id,
                        principalTable: "Deck",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Deck_WinningDeckId",
                        column: x => x.WinningDeckId,
                        principalTable: "Deck",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Players_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Players_Player3Id",
                        column: x => x.Player3Id,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Players_Player4Id",
                        column: x => x.Player4Id,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Players_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deck_PlayerId",
                table: "Deck",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Deck2Id",
                table: "Games",
                column: "Deck2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Deck3Id",
                table: "Games",
                column: "Deck3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Deck4Id",
                table: "Games",
                column: "Deck4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player2Id",
                table: "Games",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player3Id",
                table: "Games",
                column: "Player3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player4Id",
                table: "Games",
                column: "Player4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_WinnerId",
                table: "Games",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_WinningDeckId",
                table: "Games",
                column: "WinningDeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
