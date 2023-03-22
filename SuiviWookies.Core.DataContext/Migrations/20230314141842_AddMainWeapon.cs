using Microsoft.EntityFrameworkCore.Migrations;

namespace SuiviWookies.Core.DataContext.Migrations
{
    public partial class AddMainWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainWeaponId",
                table: "Wookies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wookies_MainWeaponId",
                table: "Wookies",
                column: "MainWeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wookies_Weapons_MainWeaponId",
                table: "Wookies",
                column: "MainWeaponId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wookies_Weapons_MainWeaponId",
                table: "Wookies");

            migrationBuilder.DropIndex(
                name: "IX_Wookies_MainWeaponId",
                table: "Wookies");

            migrationBuilder.DropColumn(
                name: "MainWeaponId",
                table: "Wookies");
        }
    }
}
