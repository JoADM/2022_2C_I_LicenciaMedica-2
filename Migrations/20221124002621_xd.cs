using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenciaMedica.Migrations
{
    public partial class xd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios",
                column: "PrestadoraId",
                principalTable: "Prestadoras",
                principalColumn: "PrestadoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios",
                column: "PrestadoraId",
                principalTable: "Prestadoras",
                principalColumn: "PrestadoraId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
