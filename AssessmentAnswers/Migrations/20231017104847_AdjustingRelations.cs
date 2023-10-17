using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class AdjustingRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestionRelations_AssessmentQuestionId",
                table: "AssessmentQuestionRelations",
                column: "AssessmentQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentQuestionRelations_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentQuestionRelations",
                column: "AssessmentQuestionId",
                principalTable: "AssessmentQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentQuestionRelations_AssessmentQuestions_AssessmentQuestionId",
                table: "AssessmentQuestionRelations");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentQuestionRelations_AssessmentQuestionId",
                table: "AssessmentQuestionRelations");
        }
    }
}
