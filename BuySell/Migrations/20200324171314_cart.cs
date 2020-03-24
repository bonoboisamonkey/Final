using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuySell.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserSurname",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CostumerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => new { x.CostumerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 19, 45, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 6, 58, 52, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2020, 3, 3, 5, 42, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2020, 3, 6, 23, 35, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 8, 7, 22, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 4, 49, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 9, 57, 35, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 21, 47, 19, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2020, 3, 16, 5, 30, 27, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 6, 13, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 14, 55, 13, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2020, 3, 14, 7, 33, 33, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 2, 26, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 10, 42, 48, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 3, 49, 16, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 7, 15, 22, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 23, 30, 47, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2020, 3, 19, 23, 17, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 13, 54, 51, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 1, 16, 58, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 20, 49, 24, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 11, 14, 12, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 3, 6, 20, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 17, 17, 47, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 1, 38, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2020, 3, 4, 11, 28, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 17, 48, 43, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 11, 56, 28, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 7, 34, 40, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 6, 15, 58, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 8, 10, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 20, 50, 4, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 18, 28, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 18, 31, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 16, 18, 43, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 5, 17, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 20, 18, 52, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 15, 7, 54, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 18, 42, 39, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2020, 3, 19, 4, 12, 38, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2020, 3, 16, 8, 42, 7, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2020, 3, 5, 14, 3, 46, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 21, 32, 45, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2020, 3, 18, 4, 24, 48, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 22, 56, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 12, 32, 41, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 22, 32, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2020, 3, 3, 5, 4, 14, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2020, 3, 18, 19, 36, 13, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2020, 3, 4, 13, 24, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 2, 35, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 2, 23, 58, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 9, 25, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 23, 44, 3, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 10, 31, 55, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 1, 17, 46, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 8, 56, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 14, 16, 13, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 12, 9, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 18, 16, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 23, 41, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 8, 42, 21, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 9, 58, 12, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 18, 0, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 18, 49, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 14, 50, 42, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 8, 50, 37, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 4, 41, 33, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 13, 9, 38, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 17, 17, 18, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2020, 3, 9, 6, 42, 4, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 3, 9, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 0, 20, 30, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 4, 27, 46, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 11, 20, 23, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 2, 31, 11, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 21, 45, 9, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 20, 44, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 9, 38, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 4, 28, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2020, 3, 18, 12, 7, 34, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 20, 2, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 23, 57, 35, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 14, 44, 41, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 3, 33, 51, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2020, 3, 4, 5, 47, 55, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2020, 3, 19, 23, 47, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 15, 45, 24, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 17, 0, 52, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2020, 3, 3, 5, 15, 49, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 10, 52, 13, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 1, 50, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2020, 3, 19, 18, 8, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 13, 27, 3, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2020, 3, 9, 1, 19, 35, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 18, 20, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 17, 8, 22, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 23, 45, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 23, 13, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2020, 3, 5, 16, 36, 20, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 5, 12, 24, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2020, 3, 4, 21, 54, 13, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 18, 4, 39, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2020, 3, 16, 19, 49, 52, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 13, 43, 56, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2020, 3, 14, 17, 49, 57, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 18, 19, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 4, 38, 51, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 4, 57, 24, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 10, 19, 49, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 15, 18, 34, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 3, 49, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2020, 3, 3, 13, 20, 47, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 14, 23, 2, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 9, 55, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 6, 11, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 13, 50, 50, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 16, 5, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 6, 16, 39, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 15, 52, 14, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 18, 5, 6, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 0, 19, 41, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 5, 12, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 20, 1, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 3, 39, 56, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 0, 54, 49, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2020, 3, 18, 6, 20, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 5, 54, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 3, 33, 20, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 5, 15, 28, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 11, 34, 46, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 17, 46, 24, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 16, 17, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 13, 47, 28, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 18, 1, 41, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 10, 58, 54, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 21, 44, 11, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2020, 3, 4, 0, 53, 16, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.AlterColumn<string>(
                name: "UserSurname",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 23, 28, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 23, 1, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2020, 3, 18, 2, 0, 58, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2020, 3, 6, 1, 58, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 17, 32, 35, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 18, 17, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 10, 9, 7, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2020, 3, 3, 20, 7, 49, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 9, 6, 12, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 7, 1, 30, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 22, 0, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 18, 12, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 16, 24, 3, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 4, 55, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 23, 0, 25, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 14, 23, 52, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2020, 3, 6, 18, 17, 37, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2020, 3, 14, 2, 28, 30, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 10, 2, 17, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 2, 59, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 14, 39, 5, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 9, 17, 12, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 12, 38, 48, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2020, 3, 5, 13, 44, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2020, 3, 9, 10, 4, 30, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 2, 31, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2020, 3, 9, 21, 59, 40, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 1, 53, 20, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 8, 38, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 12, 9, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 21, 50, 49, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 20, 56, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 11, 13, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 0, 35, 23, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 17, 38, 34, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2020, 3, 16, 11, 13, 40, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 21, 4, 49, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 9, 8, 22, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 13, 2, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 16, 53, 47, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 22, 51, 29, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 9, 44, 38, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 0, 39, 8, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 0, 28, 4, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2020, 3, 19, 4, 23, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 2, 37, 22, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 16, 53, 58, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2020, 3, 19, 10, 0, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 6, 47, 14, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 6, 57, 19, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 8, 22, 39, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2020, 3, 16, 21, 6, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2020, 3, 6, 3, 53, 43, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 4, 43, 57, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 6, 3, 43, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 11, 29, 22, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 18, 36, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 4, 18, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 10, 39, 58, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 10, 11, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 6, 32, 35, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 11, 40, 40, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 7, 14, 38, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 17, 42, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2020, 3, 8, 5, 56, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 21, 49, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 2, 45, 7, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 11, 35, 13, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 6, 3, 9, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 7, 32, 18, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 12, 5, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 4, 55, 48, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 8, 11, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 13, 54, 4, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 0, 53, 36, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 0, 40, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2020, 3, 24, 9, 46, 54, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2020, 3, 3, 21, 20, 42, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 3, 6, 7, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 21, 33, 53, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2020, 3, 14, 18, 28, 19, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 8, 23, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2020, 3, 5, 13, 11, 46, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 14, 48, 4, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 14, 39, 34, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 17, 9, 9, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 21, 34, 51, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 1, 50, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 3, 24, 34, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 7, 3, 39, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 8, 12, 57, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2020, 3, 18, 18, 12, 6, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2020, 3, 20, 14, 51, 48, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 17, 56, 38, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 18, 9, 41, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2020, 3, 14, 2, 6, 21, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2020, 3, 22, 5, 58, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 4, 31, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2020, 3, 12, 4, 37, 16, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 0, 35, 9, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 15, 21, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 20, 17, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2020, 3, 13, 20, 23, 16, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 16, 9, 52, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 13, 27, 48, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 0, 18, 54, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 5, 53, 11, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 19, 20, 26, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 2, 23, 33, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 6, 45, 4, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 22, 53, 2, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 4, 57, 6, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 23, 34, 47, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2020, 3, 17, 15, 19, 44, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 11, 13, 41, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 3, 53, 56, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2020, 3, 21, 19, 53, 23, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 10, 5, 54, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2020, 2, 24, 15, 59, 47, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2020, 3, 15, 11, 44, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2020, 2, 28, 7, 37, 10, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2020, 2, 25, 1, 3, 34, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 13, 31, 28, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2020, 3, 6, 19, 10, 9, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 10, 2, 5, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2020, 3, 10, 1, 34, 37, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2020, 3, 1, 7, 54, 43, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2020, 2, 27, 3, 48, 56, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 18, 9, 27, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2020, 3, 16, 11, 56, 56, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2020, 3, 6, 0, 56, 15, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2020, 2, 26, 0, 0, 1, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2020, 3, 23, 11, 29, 59, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 22, 16, 32, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2020, 3, 7, 1, 57, 55, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2020, 3, 2, 17, 56, 42, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2020, 2, 29, 7, 45, 42, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2020, 3, 11, 17, 47, 27, 0, DateTimeKind.Local));
        }
    }
}
