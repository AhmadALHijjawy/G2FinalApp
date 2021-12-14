using Microsoft.EntityFrameworkCore.Migrations;

namespace G2FinalApp.Migrations
{
    public partial class clientImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientImg",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientImg",
                table: "Clients");
        }
    }
}
