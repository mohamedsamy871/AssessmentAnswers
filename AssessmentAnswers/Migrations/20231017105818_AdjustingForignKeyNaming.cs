using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class AdjustingForignKeyNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentAnswers_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentMatch_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentOptions_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentText_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentText");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "AssessmentText");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "AssessmentOptions");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "AssessmentMatch");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "AssessmentAnswers");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentText",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentOptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentMatch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentAnswers_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentAnswers",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentMatch_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentMatch",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentOptions_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentOptions",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentText_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentText",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentAnswers_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentMatch_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentOptions_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentText_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentText");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentText",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "AssessmentText",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "AssessmentOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentMatch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "AssessmentMatch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentQuestionId",
                table: "AssessmentAnswers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "AssessmentAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentAnswers_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentAnswers",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentMatch_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentMatch",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentOptions_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentOptions",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentText_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentText",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id");
        }
    }
}
