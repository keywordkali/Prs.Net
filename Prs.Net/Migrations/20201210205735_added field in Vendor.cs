using Microsoft.EntityFrameworkCore.Migrations;

namespace Prs.Net.Migrations
{
    public partial class addedfieldinVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vendors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vendors");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 30);
        }
    }
}
