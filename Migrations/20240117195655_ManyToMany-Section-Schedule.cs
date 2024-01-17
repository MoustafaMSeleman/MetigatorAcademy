using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Metigator_ep10.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManySectionSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedules_ScheduleId",
                table: "SectionSchedules",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionSchedules_Schedules_ScheduleId",
                table: "SectionSchedules",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionSchedules_Sections_SectionId",
                table: "SectionSchedules",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionSchedules_Schedules_ScheduleId",
                table: "SectionSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionSchedules_Sections_SectionId",
                table: "SectionSchedules");

            migrationBuilder.DropIndex(
                name: "IX_SectionSchedules_ScheduleId",
                table: "SectionSchedules");
        }
    }
}
