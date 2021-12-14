using Microsoft.EntityFrameworkCore.Migrations;

namespace G2FinalApp.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAcc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterAcc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinAcc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
