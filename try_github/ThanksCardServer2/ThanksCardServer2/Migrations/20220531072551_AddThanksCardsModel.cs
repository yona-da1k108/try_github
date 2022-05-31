using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ThanksCardServer2.Migrations
{
    public partial class AddThanksCardsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThanksCards",
                columns: table => new
                {
                    ThanksCard_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ThanksCard_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sender_Id = table.Column<long>(type: "bigint", nullable: false),
                    Destination_Id = table.Column<long>(type: "bigint", nullable: false),
                    Title_Id = table.Column<long>(type: "bigint", nullable: false),
                    ThanksCard_Content = table.Column<string>(type: "text", nullable: true),
                    Template_Id = table.Column<long>(type: "bigint", nullable: false),
                    Good_Number = table.Column<long>(type: "bigint", nullable: false),
                    Alreadtread = table.Column<string>(type: "text", nullable: true),
                    Thankscardsonzai_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanksCards", x => x.ThanksCard_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThanksCards");
        }
    }
}
