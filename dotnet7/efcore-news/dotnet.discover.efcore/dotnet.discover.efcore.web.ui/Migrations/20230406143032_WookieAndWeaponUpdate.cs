using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.discover.efcore.web.ui.Migrations
{
    /// <inheritdoc />
    public partial class WookieAndWeaponUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Wookie_WookieId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_WookieId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "WookieId",
                table: "Weapons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WookieId",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WookieId",
                table: "Weapons",
                column: "WookieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Wookie_WookieId",
                table: "Weapons",
                column: "WookieId",
                principalTable: "Wookie",
                principalColumn: "Id");
        }
    }
}
