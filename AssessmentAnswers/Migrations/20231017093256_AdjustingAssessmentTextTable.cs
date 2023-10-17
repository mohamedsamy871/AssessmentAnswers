using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class AdjustingAssessmentTextTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssessmentTextType",
                table: "AssessmentText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssessmentTextType",
                table: "AssessmentText",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
