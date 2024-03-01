using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtgServer.Migrations
{
    /// <inheritdoc />
    public partial class GameTimespan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "DurationMinutes",
                table: "Games",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationMinutes",
                table: "Games");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Games",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
