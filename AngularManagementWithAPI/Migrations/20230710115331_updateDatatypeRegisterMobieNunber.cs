using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineManagement.Migrations
{
    public partial class updateDatatypeRegisterMobieNunber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MobileNumber",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
