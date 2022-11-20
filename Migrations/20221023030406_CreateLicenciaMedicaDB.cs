using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenciaMedica.Migrations
{
    public partial class CreateLicenciaMedicaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Licencias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadoID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicoID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FechaInicioSolicitada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinSolicitada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prestadoras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoContactoID = table.Column<int>(type: "int", nullable: false),
                    MailContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestadoras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAlta = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObraSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoActivo = table.Column<bool>(type: "bit", nullable: true),
                    EmpleadoRRHH = table.Column<bool>(type: "bit", nullable: true),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrestadoraID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Usuarios_Prestadoras_PrestadoraID",
                        column: x => x.PrestadoraID,
                        principalTable: "Prestadoras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    num = table.Column<int>(type: "int", nullable: false),
                    TipoDeTelefono = table.Column<int>(type: "int", nullable: false),
                    UsuarioID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Telefonos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Licencias_EmpleadoID",
                table: "Licencias",
                column: "EmpleadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Licencias_MedicoID",
                table: "Licencias",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestadoras_TelefonoContactoID",
                table: "Prestadoras",
                column: "TelefonoContactoID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_UsuarioID",
                table: "Telefonos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PrestadoraID",
                table: "Usuarios",
                column: "PrestadoraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Licencias_Usuarios_EmpleadoID",
                table: "Licencias",
                column: "EmpleadoID",
                principalTable: "Usuarios",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Licencias_Usuarios_MedicoID",
                table: "Licencias",
                column: "MedicoID",
                principalTable: "Usuarios",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestadoras_Telefonos_TelefonoContactoID",
                table: "Prestadoras",
                column: "TelefonoContactoID",
                principalTable: "Telefonos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioID",
                table: "Telefonos");

            migrationBuilder.DropTable(
                name: "Licencias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Prestadoras");

            migrationBuilder.DropTable(
                name: "Telefonos");
        }
    }
}
