using Microsoft.EntityFrameworkCore.Migrations;

namespace Pillow.Infrastruture.Sql.Migrations
{
    public partial class paymentNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentNote",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentNote",
                table: "Orders");
        }
    }
}
