using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject03.Data.Migrations
{
    public partial class AddingBusTrainHotelBlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LocationMap",
                table: "Location",
                type: "nvarchar(900)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.CreateTable(
                name: "BlogsPost",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostsName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BlogTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BlogDescription = table.Column<string>(type: "text", nullable: false),
                    BlogsRating = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AuthorsName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PostedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogsPost", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "BusData",
                columns: table => new
                {
                    BusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BusCompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BusTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BusDescription = table.Column<string>(type: "text", nullable: false),
                    BusMap = table.Column<string>(type: "nvarchar(900)", nullable: false),
                    BusRating = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BusSeatType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BusSeatPrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    BusDepartureLocation = table.Column<string>(type: "nvarchar(900)", nullable: false),
                    BusArrivalLocation = table.Column<string>(type: "nvarchar(900)", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusData", x => x.BusId);
                });

            migrationBuilder.CreateTable(
                name: "HotelsData",
                columns: table => new
                {
                    HotelsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelsName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HotelsCompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    HotelsTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HotelsDescription = table.Column<string>(type: "text", nullable: false),
                    HotelsMap = table.Column<string>(type: "nvarchar(900)", nullable: false),
                    HotelsRating = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HotelsRoomtype = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HotelsSeatPrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelsData", x => x.HotelsId);
                });

            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    TrainId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrainCompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TrainTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrainDescription = table.Column<string>(type: "text", nullable: false),
                    TrainMap = table.Column<string>(type: "nvarchar(900)", nullable: false),
                    TrainRating = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrainSeatType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrainSeatPrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrainDepartureLocation = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    TrainArrivalLocation = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.TrainId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogsPost");

            migrationBuilder.DropTable(
                name: "BusData");

            migrationBuilder.DropTable(
                name: "HotelsData");

            migrationBuilder.DropTable(
                name: "Train");

            migrationBuilder.AlterColumn<string>(
                name: "LocationMap",
                table: "Location",
                type: "nvarchar(900)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)");
        }
    }
}
