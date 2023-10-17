using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class AdjustingAssessmemtOptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssessmentOptionType",
                table: "AssessmentOptions");

            migrationBuilder.DropColumn(
                name: "AssessmentMatchType",
                table: "AssessmentMatch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssessmentOptionType",
                table: "AssessmentOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssessmentMatchType",
                table: "AssessmentMatch",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
