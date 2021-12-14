using Microsoft.EntityFrameworkCore.Migrations;

namespace G2FinalApp.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<bool>(type: "bit", nullable: false),
                    ProdDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catagory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
