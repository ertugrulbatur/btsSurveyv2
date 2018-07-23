using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Survey2.Data.Migrations
{
    public partial class FluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Annoucement_AnnoucementId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Survey_SurveyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_AspNetUsers_UserId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_SurveyId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_UserId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AnnoucementId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SurveyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "AnnoucementId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Answer");

            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "Survey",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UID",
                table: "Question",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "Answer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "Annoucement",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(type: "varchar(200)", nullable: true),
                    UID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaint_AspNetUsers_UID",
                        column: x => x.UID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Survey_UID",
                table: "Survey",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_SID",
                table: "Question",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_UID",
                table: "Question",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_UID",
                table: "Answer",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Annoucement_UID",
                table: "Annoucement",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_UID",
                table: "Complaint",
                column: "UID");

            migrationBuilder.AddForeignKey(
                name: "FK_Annoucement_AspNetUsers_UID",
                table: "Annoucement",
                column: "UID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_AspNetUsers_UID",
                table: "Answer",
                column: "UID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Survey_SID",
                table: "Question",
                column: "SID",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_AspNetUsers_UID",
                table: "Question",
                column: "UID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Survey_AspNetUsers_UID",
                table: "Survey",
                column: "UID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Annoucement_AspNetUsers_UID",
                table: "Annoucement");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_AspNetUsers_UID",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Survey_SID",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_AspNetUsers_UID",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Survey_AspNetUsers_UID",
                table: "Survey");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Survey_UID",
                table: "Survey");

            migrationBuilder.DropIndex(
                name: "IX_Question_SID",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_UID",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Answer_UID",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Annoucement_UID",
                table: "Annoucement");

            migrationBuilder.DropColumn(
                name: "UID",
                table: "Survey");

            migrationBuilder.DropColumn(
                name: "UID",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "UID",
                table: "Annoucement");

            migrationBuilder.AlterColumn<Guid>(
                name: "UID",
                table: "Question",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SurveyId",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AnnoucementId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SurveyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Answer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Question_SurveyId",
                table: "Question",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_UserId",
                table: "Question",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AnnoucementId",
                table: "AspNetUsers",
                column: "AnnoucementId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SurveyId",
                table: "AspNetUsers",
                column: "SurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Annoucement_AnnoucementId",
                table: "AspNetUsers",
                column: "AnnoucementId",
                principalTable: "Annoucement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Survey_SurveyId",
                table: "AspNetUsers",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_AspNetUsers_UserId",
                table: "Question",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
