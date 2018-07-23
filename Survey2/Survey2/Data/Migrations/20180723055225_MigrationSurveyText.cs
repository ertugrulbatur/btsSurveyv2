using Microsoft.EntityFrameworkCore.Migrations;

namespace Survey2.Data.Migrations
{
    public partial class MigrationSurveyText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Survey",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Survey");
        }
    }
}
