using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenciaMedica.Migrations
{
    public partial class LicenciaMedicaDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PrestadoraId",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PrestadoraId",
                table: "Usuarios",
                column: "PrestadoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios",
                column: "PrestadoraId",
                principalTable: "Prestadoras",
                principalColumn: "PrestadoraId");
        }
    }
}
