using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Survey2.Data.Migrations
{
    public partial class MigrationDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TimeStamp",
                table: "Survey",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Survey",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "TimeStamp",
                table: "Question",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Question",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "TimeStamp",
                table: "Choice",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Choice",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "TimeStamp",
                table: "Answer",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Answer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Choice");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Choice");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Answer");
        }
    }
}
