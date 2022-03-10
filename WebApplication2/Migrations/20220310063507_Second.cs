using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Leaders_LeaderId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Surveys_SurveyId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Admins_AdminId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Leaders_LeaderId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leaders",
                table: "Leaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Surveys",
                newName: "Survey");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Leaders",
                newName: "Leader");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_LeaderId",
                table: "Survey",
                newName: "IX_Survey_LeaderId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_AdminId",
                table: "Survey",
                newName: "IX_Survey_AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SurveyId",
                table: "Question",
                newName: "IX_Question_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_LeaderId",
                table: "Employee",
                newName: "IX_Employee_LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Survey",
                table: "Survey",
                column: "SurveyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leader",
                table: "Leader",
                column: "LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Leader_LeaderId",
                table: "Employee",
                column: "LeaderId",
                principalTable: "Leader",
                principalColumn: "LeaderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "SurveyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Survey_Admin_AdminId",
                table: "Survey",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Survey_Leader_LeaderId",
                table: "Survey",
                column: "LeaderId",
                principalTable: "Leader",
                principalColumn: "LeaderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Leader_LeaderId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Survey_Admin_AdminId",
                table: "Survey");

            migrationBuilder.DropForeignKey(
                name: "FK_Survey_Leader_LeaderId",
                table: "Survey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Survey",
                table: "Survey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leader",
                table: "Leader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Survey",
                newName: "Surveys");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Leader",
                newName: "Leaders");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.RenameIndex(
                name: "IX_Survey_LeaderId",
                table: "Surveys",
                newName: "IX_Surveys_LeaderId");

            migrationBuilder.RenameIndex(
                name: "IX_Survey_AdminId",
                table: "Surveys",
                newName: "IX_Surveys_AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_SurveyId",
                table: "Questions",
                newName: "IX_Questions_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_LeaderId",
                table: "Employees",
                newName: "IX_Employees_LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys",
                column: "SurveyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leaders",
                table: "Leaders",
                column: "LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Leaders_LeaderId",
                table: "Employees",
                column: "LeaderId",
                principalTable: "Leaders",
                principalColumn: "LeaderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Surveys_SurveyId",
                table: "Questions",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "SurveyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Admins_AdminId",
                table: "Surveys",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Leaders_LeaderId",
                table: "Surveys",
                column: "LeaderId",
                principalTable: "Leaders",
                principalColumn: "LeaderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
