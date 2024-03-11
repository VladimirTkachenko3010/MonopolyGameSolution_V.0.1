using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonopolyWebApp.Migrations
{
    /// <inheritdoc />
    public partial class FirstCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChanceId = table.Column<int>(type: "int", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.CardId);
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "CardId", "Action", "CardType", "ChanceId", "Description", "Price" },
                values: new object[] { 1, "advanceGo", null, 0, "Advance to Go (collect 200$)", 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
