using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    public partial class Initiating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentEnrols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentEnrols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentQuestionRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentQuestionRelations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentAnswers_AssessmentQuestions_AssessmentQuestionId",
                        column: x => x.AssessmentQuestionId,
                        principalTable: "AssessmentQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentMatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentMatchType = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentMatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentMatch_AssessmentQuestions_AssessmentQuestionId",
                        column: x => x.AssessmentQuestionId,
                        principalTable: "AssessmentQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentOptionType = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentOptions_AssessmentQuestions_AssessmentQuestionId",
                        column: x => x.AssessmentQuestionId,
                        principalTable: "AssessmentQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentTextType = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentText", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentText_AssessmentQuestions_AssessmentQuestionId",
                        column: x => x.AssessmentQuestionId,
                        principalTable: "AssessmentQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentTrueFalse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentTrueFalse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentTrueFalse_AssessmentQuestions_AssessmentQuestionId",
                        column: x => x.AssessmentQuestionId,
                        principalTable: "AssessmentQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentAnswers_AssessmentQuestionId",
                table: "AssessmentAnswers",
                column: "AssessmentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentMatch_AssessmentQuestionId",
                table: "AssessmentMatch",
                column: "AssessmentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentOptions_AssessmentQuestionId",
                table: "AssessmentOptions",
                column: "AssessmentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentText_AssessmentQuestionId",
                table: "AssessmentText",
                column: "AssessmentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentTrueFalse_AssessmentQuestionId",
                table: "AssessmentTrueFalse",
                column: "AssessmentQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentAnswers");

            migrationBuilder.DropTable(
                name: "AssessmentEnrols");

            migrationBuilder.DropTable(
                name: "AssessmentMatch");

            migrationBuilder.DropTable(
                name: "AssessmentOptions");

            migrationBuilder.DropTable(
                name: "AssessmentQuestionRelations");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "AssessmentText");

            migrationBuilder.DropTable(
                name: "AssessmentTrueFalse");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AssessmentQuestions");
        }
    }
}
