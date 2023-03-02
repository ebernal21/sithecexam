using Microsoft.EntityFrameworkCore.Migrations;

namespace SithecExamErickBernal.Migrations
{
    public partial class tableHuman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Humans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    age = table.Column<string>(nullable: true),
                    height = table.Column<decimal>(nullable: false),
                    weight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humans", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Humans");
        }
    }
}
