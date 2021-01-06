using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pillow.Infrastruture.Sql.Migrations
{
    public partial class ProductInsertTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InseretTime",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InseretTime",
                table: "Products");
        }
    }
}
