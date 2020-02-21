using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuySell.Migrations
{
    public partial class ordercancelationthings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancelationDate",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Orders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelationDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Orders");
        }
    }
}
