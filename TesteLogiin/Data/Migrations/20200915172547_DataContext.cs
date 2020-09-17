using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteLogiin.Migrations
{
    public partial class DataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataForGrid",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AccountNumber = table.Column<int>(nullable: false),
                    AccountBalance = table.Column<double>(nullable: false),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataForGrid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataForGrid");
        }
    }
}
