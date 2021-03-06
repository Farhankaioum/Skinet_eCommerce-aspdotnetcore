﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Skinet.Infrastructure.Data.Migrations
{
    public partial class RenameProductBandNavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_ProductBandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductBandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductBandId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductBrandId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products",
                column: "ProductBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_ProductBrandId",
                table: "Products",
                column: "ProductBrandId",
                principalTable: "ProductBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_ProductBrandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductBrandId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductBandId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBandId",
                table: "Products",
                column: "ProductBandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_ProductBandId",
                table: "Products",
                column: "ProductBandId",
                principalTable: "ProductBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
