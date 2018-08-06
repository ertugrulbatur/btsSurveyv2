using Microsoft.EntityFrameworkCore.Migrations;

namespace Survey2.Data.Migrations
{
    public partial class QuestionChoiceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Choice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Choice");
        }
    }
}
