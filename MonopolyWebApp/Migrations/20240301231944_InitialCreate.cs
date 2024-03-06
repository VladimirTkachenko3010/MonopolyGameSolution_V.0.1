using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonopolyWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    RentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentBase = table.Column<int>(type: "int", nullable: false),
                    RentOne = table.Column<int>(type: "int", nullable: false),
                    RentTwo = table.Column<int>(type: "int", nullable: false),
                    RentThree = table.Column<int>(type: "int", nullable: false),
                    RentFour = table.Column<int>(type: "int", nullable: false),
                    RentHotel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.RentID);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    RentID = table.Column<int>(type: "int", nullable: true),
                    MortageValue = table.Column<int>(type: "int", nullable: false),
                    IsMortagaged = table.Column<bool>(type: "bit", nullable: false),
                    BuildingCost = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_Property_Rent_RentID",
                        column: x => x.RentID,
                        principalTable: "Rent",
                        principalColumn: "RentID");
                });

            migrationBuilder.CreateTable(
                name: "Spaces",
                columns: table => new
                {
                    SpaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyID = table.Column<int>(type: "int", nullable: true),
                    HasProp = table.Column<bool>(type: "bit", nullable: false),
                    BuildingAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaces", x => x.SpaceID);
                    table.ForeignKey(
                        name: "FK_Spaces_Property_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Property",
                        principalColumn: "PropertyID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_RentID",
                table: "Property",
                column: "RentID");

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_PropertyID",
                table: "Spaces",
                column: "PropertyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spaces");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Rent");
        }
    }
}
