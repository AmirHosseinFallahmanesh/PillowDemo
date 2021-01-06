using Microsoft.EntityFrameworkCore.Migrations;

namespace Pillow.Infrastruture.Sql.Migrations
{
    public partial class zipCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Orders");
        }
    }
}
