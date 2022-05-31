using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThanksCardServer2.Migrations
{
    public partial class AddEmployee1Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "Employee_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_Id",
                table: "Employees",
                newName: "Id");
        }
    }
}
