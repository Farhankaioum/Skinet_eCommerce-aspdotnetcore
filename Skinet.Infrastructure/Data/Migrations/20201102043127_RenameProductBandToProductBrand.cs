using Microsoft.EntityFrameworkCore.Migrations;

namespace Skinet.Infrastructure.Data.Migrations
{
    public partial class RenameProductBandToProductBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBands_ProductBandId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductBands");

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_ProductBandId",
                table: "Products",
                column: "ProductBandId",
                principalTable: "ProductBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_ProductBandId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.CreateTable(
                name: "ProductBands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBands", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBands_ProductBandId",
                table: "Products",
                column: "ProductBandId",
                principalTable: "ProductBands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
