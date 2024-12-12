using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecop.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourtDes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourtDecisionId",
                table: "TrafficViolations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourtDecisions",
                columns: table => new
                {
                    CourtDecisionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Violationid = table.Column<int>(type: "int", nullable: false),
                    Courtid = table.Column<int>(type: "int", nullable: false),
                    Verdict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Penalty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JudgeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtDecisions", x => x.CourtDecisionsId);
                    table.ForeignKey(
                        name: "FK_CourtDecisions_Courts_Courtid",
                        column: x => x.Courtid,
                        principalTable: "Courts",
                        principalColumn: "CourtId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourtDecisions_Judges_JudgeId",
                        column: x => x.JudgeId,
                        principalTable: "Judges",
                        principalColumn: "JudgeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourtDecisions_TrafficViolations_Violationid",
                        column: x => x.Violationid,
                        principalTable: "TrafficViolations",
                        principalColumn: "TrafficViolationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_Courtid",
                table: "CourtDecisions",
                column: "Courtid");

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_JudgeId",
                table: "CourtDecisions",
                column: "JudgeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_Violationid",
                table: "CourtDecisions",
                column: "Violationid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourtDecisions");

            migrationBuilder.DropColumn(
                name: "CourtDecisionId",
                table: "TrafficViolations");
        }
    }
}
