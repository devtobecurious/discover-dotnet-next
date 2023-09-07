using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConnectWithEfCore.Migrations
{
    public partial class AddWand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavoriteWandId",
                table: "Wizard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Wand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wand", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wizard_FavoriteWandId",
                table: "Wizard",
                column: "FavoriteWandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wizard_Wand_FavoriteWandId",
                table: "Wizard",
                column: "FavoriteWandId",
                principalTable: "Wand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wizard_Wand_FavoriteWandId",
                table: "Wizard");

            migrationBuilder.DropTable(
                name: "Wand");

            migrationBuilder.DropIndex(
                name: "IX_Wizard_FavoriteWandId",
                table: "Wizard");

            migrationBuilder.DropColumn(
                name: "FavoriteWandId",
                table: "Wizard");
        }
    }
}
