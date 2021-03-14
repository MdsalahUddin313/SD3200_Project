using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject03.Data.Migrations
{
    public partial class AddingOrderAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HotelsMap",
                table: "HotelsData",
                type: "nvarchar(900)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10000)");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    HotelsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_HotelsData_HotelsId",
                        column: x => x.HotelsId,
                        principalTable: "HotelsData",
                        principalColumn: "HotelsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_HotelsId",
                table: "OrderDetails",
                column: "HotelsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "HotelsMap",
                table: "HotelsData",
                type: "nvarchar(10000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(900)");
        }
    }
}
