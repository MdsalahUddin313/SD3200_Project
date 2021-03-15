using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject03.Data.Migrations
{
    public partial class addingCheckOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_HotelsData_HotelsId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "HotelsId",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationMap",
                table: "Location",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10000)");

            migrationBuilder.CreateTable(
                name: "CheckOut",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CardNo = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    CardPin = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentAmount = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOut", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_HotelsData_HotelsId",
                table: "OrderDetails",
                column: "HotelsId",
                principalTable: "HotelsData",
                principalColumn: "HotelsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_HotelsData_HotelsId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "CheckOut");

            migrationBuilder.AlterColumn<int>(
                name: "HotelsId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LocationMap",
                table: "Location",
                type: "nvarchar(10000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_HotelsData_HotelsId",
                table: "OrderDetails",
                column: "HotelsId",
                principalTable: "HotelsData",
                principalColumn: "HotelsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
