using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtgServer.Migrations
{
    /// <inheritdoc />
    public partial class GameContents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deck2Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck3Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck4Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player3Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player4Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "WinnerId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "WinningDeckId",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "Deck2",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deck2Commander",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deck3",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deck3Commander",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deck4",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deck4Commander",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player2",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player3",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player4",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Winner",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinningDeck",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinningDeckCommander",
                table: "Games",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deck2",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck2Commander",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck3",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck3Commander",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck4",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Deck4Commander",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player3",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player4",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Winner",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "WinningDeck",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "WinningDeckCommander",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "Deck2Id",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Deck3Id",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Deck4Id",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2Id",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player3Id",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player4Id",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerId",
                table: "Games",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinningDeckId",
                table: "Games",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
