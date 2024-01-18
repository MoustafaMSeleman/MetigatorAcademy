using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Metigator_ep10.Migrations
{
    /// <inheritdoc />
    public partial class AddIdForSectionSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionSchedules",
                table: "SectionSchedules");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SectionSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionSchedules",
                table: "SectionSchedules",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedules_SectionId",
                table: "SectionSchedules",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionSchedules",
                table: "SectionSchedules");

            migrationBuilder.DropIndex(
                name: "IX_SectionSchedules_SectionId",
                table: "SectionSchedules");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SectionSchedules");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionSchedules",
                table: "SectionSchedules",
                columns: new[] { "SectionId", "ScheduleId", "StartTime", "EndTime" });
        }
    }
}
