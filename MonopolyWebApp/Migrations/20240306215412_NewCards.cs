using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonopolyWebApp.Migrations
{
    /// <inheritdoc />
    public partial class NewCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Property_PropertyID",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.RenameColumn(
                name: "PropertyID",
                table: "Spaces",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Spaces_PropertyID",
                table: "Spaces",
                newName: "IX_Spaces_PropertyId");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "Spaces",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "CardId");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "Price",
                value: 0);

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Action", "CardType", "ChanceId", "Description", "Price" },
                values: new object[,]
                {
                    { 2, "advanceProp17", null, 0, "Advance to Trafalgar Square(prop17). If you pass Go, collect $200", 0 },
                    { 3, "advanceProp7", null, 0, "Advance to PallMall(prop7) If you pass Go, collect $200", 0 },
                    { 4, "advanceUtility", null, 0, "Advance to nearest Utility", 0 },
                    { 5, "advanceRailroad", null, 0, "Advance to nearest Railroad", 0 },
                    { 6, "advanceRailroad", null, 0, "Advance to nearest Railroad", 0 },
                    { 7, "bankDividend", null, 0, "Bank pays you dividend of $50", 0 },
                    { 8, "jailFree", null, 0, "Get Out of Jail Free!", 0 },
                    { 9, "goBack3", null, 0, "Go back 3 spaces", 0 },
                    { 10, "jail", null, 0, "Go directly to Jail. Do not pass Go, do not collect $200", 0 },
                    { 11, "generalRepairs", null, 0, "Make general repairs on all your property. For each house, pay $25. For each hotel, pay $100.", 0 },
                    { 12, "poorTax", null, 0, "Pay Poor Tax of $15", 0 },
                    { 13, "advanceProp3", null, 0, "Advance to King Cross St(prop3). If you pass Go, collect $200", 0 },
                    { 14, "advanceProp28", null, 0, "Advance to Mayfair(prop28). If you pass Go, collect $200", 0 },
                    { 15, "chairman", null, 0, "You have been elected Chairman of the Board. Pay each player $50", 0 },
                    { 16, "matures", null, 0, "Your building and loan matures. Collect $150", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Property_PropertyId",
                table: "Spaces",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "PropertyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Property_PropertyId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 16);

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "Spaces",
                newName: "PropertyID");

            migrationBuilder.RenameIndex(
                name: "IX_Spaces_PropertyId",
                table: "Spaces",
                newName: "IX_Spaces_PropertyID");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyID",
                table: "Spaces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "CardId");

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 1,
                column: "Price",
                value: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Property_PropertyID",
                table: "Spaces",
                column: "PropertyID",
                principalTable: "Property",
                principalColumn: "PropertyID");
        }
    }
}
