using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject03.Data.Migrations
{
    public partial class AddingLocationIntoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LocationTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LocationDescription = table.Column<string>(type: "text", nullable: false),
                    LocationMap = table.Column<string>(type: "nvarchar(10000)", nullable: false),
                    LocationRating = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
