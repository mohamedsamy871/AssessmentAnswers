using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class AdjustingAssessmentTrueFalseTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentTrueFalse_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentTrueFalse");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "AssessmentTrueFalse");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentTrueFalse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentTrueFalse_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentTrueFalse",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentTrueFalse_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentTrueFalse");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentTrueFalse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "AssessmentTrueFalse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentTrueFalse_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentTrueFalse",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id");
        }
    }
}
