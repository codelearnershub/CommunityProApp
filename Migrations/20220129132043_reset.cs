using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityProApp.Migrations
{
    public partial class reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "HotelBookings");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOutDate",
                table: "HotelBookings",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckOutDate",
                table: "HotelBookings");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "HotelBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
