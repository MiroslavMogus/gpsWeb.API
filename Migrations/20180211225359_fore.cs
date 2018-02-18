using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gpsWeb.API.Migrations
{
    public partial class fore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Lng",
                table: "Coordinates",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "Lat",
                table: "Coordinates",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Lng",
                table: "Coordinates",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<float>(
                name: "Lat",
                table: "Coordinates",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "decimal(18,6)");
        }
    }
}
