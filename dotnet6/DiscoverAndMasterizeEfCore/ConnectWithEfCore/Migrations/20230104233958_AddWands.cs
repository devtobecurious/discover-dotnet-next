using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectWithEfCore.Migrations
{
    public partial class AddWands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wizard_Wand_FavoriteWandId",
                table: "Wizard");

            migrationBuilder.DropIndex(
                name: "IX_Wizard_FavoriteWandId",
                table: "Wizard");

            migrationBuilder.DropColumn(
                name: "FavoriteWandId",
                table: "Wizard");

            migrationBuilder.CreateTable(
                name: "WandWizard",
                columns: table => new
                {
                    WandsId = table.Column<int>(type: "int", nullable: false),
                    WizardsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WandWizard", x => new { x.WandsId, x.WizardsId });
                    table.ForeignKey(
                        name: "FK_WandWizard_Wand_WandsId",
                        column: x => x.WandsId,
                        principalTable: "Wand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WandWizard_Wizard_WizardsId",
                        column: x => x.WizardsId,
                        principalTable: "Wizard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WandWizard_WizardsId",
                table: "WandWizard",
                column: "WizardsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WandWizard");

            migrationBuilder.AddColumn<int>(
                name: "FavoriteWandId",
                table: "Wizard",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
