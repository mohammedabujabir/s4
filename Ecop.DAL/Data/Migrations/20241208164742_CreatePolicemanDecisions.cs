using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecop.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePolicemanDecisions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DecisionId",
                table: "TrafficViolations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PoliceDecisionId",
                table: "CourtDecisions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PolicemanDecisions",
                columns: table => new
                {
                    PolicemanDecisionId = table.Column<int>(type: "int", nullable: false),
                    Violationid = table.Column<int>(type: "int", nullable: false),
                    Policemanid = table.Column<int>(type: "int", nullable: false),
                    DecisionNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferredToCourt = table.Column<bool>(type: "bit", nullable: false),
                    CourtDecisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicemanDecisions", x => x.PolicemanDecisionId);
                    table.ForeignKey(
                        name: "FK_PolicemanDecisions_Policemans_PolicemanDecisionId",
                        column: x => x.PolicemanDecisionId,
                        principalTable: "Policemans",
                        principalColumn: "PolicemanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicemanDecisions_TrafficViolations_Violationid",
                        column: x => x.Violationid,
                        principalTable: "TrafficViolations",
                        principalColumn: "TrafficViolationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourtDecisions_PoliceDecisionId",
                table: "CourtDecisions",
                column: "PoliceDecisionId",
                unique: true,
                filter: "[PoliceDecisionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PolicemanDecisions_Violationid",
                table: "PolicemanDecisions",
                column: "Violationid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourtDecisions_PolicemanDecisions_PoliceDecisionId",
                table: "CourtDecisions",
                column: "PoliceDecisionId",
                principalTable: "PolicemanDecisions",
                principalColumn: "PolicemanDecisionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourtDecisions_PolicemanDecisions_PoliceDecisionId",
                table: "CourtDecisions");

            migrationBuilder.DropTable(
                name: "PolicemanDecisions");

            migrationBuilder.DropIndex(
                name: "IX_CourtDecisions_PoliceDecisionId",
                table: "CourtDecisions");

            migrationBuilder.DropColumn(
                name: "DecisionId",
                table: "TrafficViolations");

            migrationBuilder.DropColumn(
                name: "PoliceDecisionId",
                table: "CourtDecisions");
        }
    }
}
