using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineManagement.Migrations
{
    public partial class addbookingtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_bookings",
                columns: table => new
                {
                    FlightID = table.Column<int>(type: "int", nullable: false),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bookings", x => x.FlightID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_bookings");
        }
    }
}
