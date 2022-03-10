using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class AddedNameToEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Question",
                table: "Question",
                newName: "question");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "question",
                table: "Question",
                newName: "Question");
        }
    }
}
