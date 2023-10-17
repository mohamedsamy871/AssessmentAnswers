using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class AdjustingUserRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "AssessmentQuestions");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentEnrols_AssessmentId",
                table: "AssessmentEnrols",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentEnrols_UserId",
                table: "AssessmentEnrols",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentEnrols_Assessments_AssessmentId",
                table: "AssessmentEnrols",
                column: "AssessmentId",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentEnrols_Users_UserId",
                table: "AssessmentEnrols",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentEnrols_Assessments_AssessmentId",
                table: "AssessmentEnrols");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentEnrols_Users_UserId",
                table: "AssessmentEnrols");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentEnrols_AssessmentId",
                table: "AssessmentEnrols");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentEnrols_UserId",
                table: "AssessmentEnrols");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "AssessmentQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
