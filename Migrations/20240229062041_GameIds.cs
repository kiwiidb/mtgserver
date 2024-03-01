using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtgServer.Migrations
{
    /// <inheritdoc />
    public partial class GameIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Deck_Deck2Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Deck_Deck3Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Deck_Deck4Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Deck_WinningDeckId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_Player2Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_Player3Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_Player4Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_WinnerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Deck2Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Deck3Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Deck4Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Player2Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Player3Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Player4Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_WinnerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_WinningDeckId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "WinningDeckId",
                table: "Games",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WinningDeckId",
                table: "Games",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Deck_Deck2Id",
                table: "Games",
                column: "Deck2Id",
                principalTable: "Deck",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Deck_Deck3Id",
                table: "Games",
                column: "Deck3Id",
                principalTable: "Deck",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Deck_Deck4Id",
                table: "Games",
                column: "Deck4Id",
                principalTable: "Deck",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Deck_WinningDeckId",
                table: "Games",
                column: "WinningDeckId",
                principalTable: "Deck",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_Player2Id",
                table: "Games",
                column: "Player2Id",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_Player3Id",
                table: "Games",
                column: "Player3Id",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_Player4Id",
                table: "Games",
                column: "Player4Id",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_WinnerId",
                table: "Games",
                column: "WinnerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
