using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductivityTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReadingSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "ReadingSession",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "ReadingSession",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndTime",
                table: "ReadingSession",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "StartTime",
                table: "ReadingSession",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "ReadingSession");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ReadingSession");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "ReadingSession");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "ReadingSession");
        }
    }
}
