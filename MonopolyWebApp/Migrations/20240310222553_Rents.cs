using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonopolyWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Rents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Rent_RentID",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Property_PropertyId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rent",
                table: "Rent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.RenameTable(
                name: "Rent",
                newName: "Rents");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameIndex(
                name: "IX_Property_RentID",
                table: "Properties",
                newName: "IX_Properties_RentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rents",
                table: "Rents",
                column: "RentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "PropertyID");

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "RentID", "RentBase", "RentFour", "RentHotel", "RentOne", "RentThree", "RentTwo" },
                values: new object[,]
                {
                    { 1, 2, 160, 250, 10, 90, 30 },
                    { 2, 4, 320, 450, 20, 180, 60 },
                    { 3, 25, 0, 0, 50, 200, 100 },
                    { 4, 6, 400, 550, 30, 270, 90 },
                    { 5, 6, 400, 550, 30, 270, 90 },
                    { 6, 8, 450, 600, 40, 300, 100 },
                    { 7, 10, 625, 750, 50, 450, 150 },
                    { 8, 0, 0, 0, 0, 0, 0 },
                    { 9, 10, 625, 750, 50, 450, 150 },
                    { 10, 12, 700, 900, 60, 500, 180 },
                    { 11, 25, 0, 0, 50, 200, 100 },
                    { 12, 14, 750, 950, 70, 550, 200 },
                    { 13, 14, 750, 950, 70, 550, 200 },
                    { 14, 16, 800, 1000, 80, 600, 220 },
                    { 15, 18, 875, 1050, 90, 700, 250 },
                    { 16, 18, 875, 1050, 90, 700, 250 },
                    { 17, 20, 925, 1100, 100, 750, 300 },
                    { 18, 25, 0, 0, 50, 200, 100 },
                    { 19, 22, 975, 1150, 110, 800, 330 },
                    { 20, 22, 975, 1150, 110, 800, 330 },
                    { 21, 0, 0, 0, 0, 0, 0 },
                    { 22, 24, 1025, 1200, 120, 850, 360 },
                    { 23, 26, 1100, 1275, 130, 900, 390 },
                    { 24, 26, 1100, 1275, 130, 900, 390 },
                    { 25, 28, 1200, 1400, 150, 1000, 450 },
                    { 26, 25, 0, 0, 50, 200, 100 },
                    { 27, 35, 1300, 1500, 175, 1100, 500 },
                    { 28, 50, 1700, 2000, 200, 1400, 600 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Rents_RentID",
                table: "Properties",
                column: "RentID",
                principalTable: "Rents",
                principalColumn: "RentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Properties_PropertyId",
                table: "Spaces",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Rents_RentID",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Properties_PropertyId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rents",
                table: "Rents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rents",
                keyColumn: "RentID",
                keyValue: 28);

            migrationBuilder.RenameTable(
                name: "Rents",
                newName: "Rent");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_RentID",
                table: "Property",
                newName: "IX_Property_RentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rent",
                table: "Rent",
                column: "RentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Rent_RentID",
                table: "Property",
                column: "RentID",
                principalTable: "Rent",
                principalColumn: "RentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Property_PropertyId",
                table: "Spaces",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "PropertyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
