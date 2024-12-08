﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopper.Migrations
{
    /// <inheritdoc />
    public partial class TaxablePriceAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TaxablePrice",
                table: "FoodItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxablePrice",
                table: "FoodItems");
        }
    }
}