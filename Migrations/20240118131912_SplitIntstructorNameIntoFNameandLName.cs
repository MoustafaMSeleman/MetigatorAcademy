using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Metigator_ep10.Migrations
{
    /// <inheritdoc />
    public partial class SplitIntstructorNameIntoFNameandLName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instructors",
                newName: "LName");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Instructors",
                newName: "Name");
        }
    }
}
