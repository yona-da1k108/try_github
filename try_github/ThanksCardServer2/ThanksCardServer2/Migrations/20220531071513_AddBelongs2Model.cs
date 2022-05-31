using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThanksCardServer2.Migrations
{
    public partial class AddBelongs2Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                table: "belongs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parent_Id",
                table: "belongs");
        }
    }
}
