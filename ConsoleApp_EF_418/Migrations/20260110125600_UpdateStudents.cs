using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp_EF_418.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_FacultyId",
                table: "students",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Faculties_FacultyId",
                table: "students",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Faculties_FacultyId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_FacultyId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Courses",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
