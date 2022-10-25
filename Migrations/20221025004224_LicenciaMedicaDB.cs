using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenciaMedica.Migrations
{
    public partial class LicenciaMedicaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licencias_Usuarios_EmpleadoID",
                table: "Licencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Licencias_Usuarios_MedicoID",
                table: "Licencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestadoras_Telefonos_TelefonoContactoID",
                table: "Prestadoras");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioID",
                table: "Telefonos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraID",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "PrestadoraID",
                table: "Usuarios",
                newName: "PrestadoraId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PrestadoraID",
                table: "Usuarios",
                newName: "IX_Usuarios_PrestadoraId");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "Telefonos",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Telefonos_UsuarioID",
                table: "Telefonos",
                newName: "IX_Telefonos_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Prestadoras",
                newName: "PrestadoraId");

            migrationBuilder.RenameColumn(
                name: "MedicoID",
                table: "Licencias",
                newName: "MedicoId");

            migrationBuilder.RenameColumn(
                name: "EmpleadoID",
                table: "Licencias",
                newName: "EmpleadoId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Licencias",
                newName: "LicenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Licencias_MedicoID",
                table: "Licencias",
                newName: "IX_Licencias_MedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Licencias_EmpleadoID",
                table: "Licencias",
                newName: "IX_Licencias_EmpleadoId");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Telefonos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TelefonoContactoID",
                table: "Prestadoras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Prestadoras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MailContacto",
                table: "Prestadoras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Prestadoras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MedicoId",
                table: "Licencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpleadoId",
                table: "Licencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licencias_Usuarios_EmpleadoId",
                table: "Licencias",
                column: "EmpleadoId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licencias_Usuarios_MedicoId",
                table: "Licencias",
                column: "MedicoId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestadoras_Telefonos_TelefonoContactoID",
                table: "Prestadoras",
                column: "TelefonoContactoID",
                principalTable: "Telefonos",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioId",
                table: "Telefonos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios",
                column: "PrestadoraId",
                principalTable: "Prestadoras",
                principalColumn: "PrestadoraId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licencias_Usuarios_EmpleadoId",
                table: "Licencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Licencias_Usuarios_MedicoId",
                table: "Licencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestadoras_Telefonos_TelefonoContactoID",
                table: "Prestadoras");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioId",
                table: "Telefonos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "PrestadoraId",
                table: "Usuarios",
                newName: "PrestadoraID");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PrestadoraId",
                table: "Usuarios",
                newName: "IX_Usuarios_PrestadoraID");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Telefonos",
                newName: "UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefonos_UsuarioId",
                table: "Telefonos",
                newName: "IX_Telefonos_UsuarioID");

            migrationBuilder.RenameColumn(
                name: "PrestadoraId",
                table: "Prestadoras",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MedicoId",
                table: "Licencias",
                newName: "MedicoID");

            migrationBuilder.RenameColumn(
                name: "EmpleadoId",
                table: "Licencias",
                newName: "EmpleadoID");

            migrationBuilder.RenameColumn(
                name: "LicenciaId",
                table: "Licencias",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Licencias_MedicoId",
                table: "Licencias",
                newName: "IX_Licencias_MedicoID");

            migrationBuilder.RenameIndex(
                name: "IX_Licencias_EmpleadoId",
                table: "Licencias",
                newName: "IX_Licencias_EmpleadoID");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Usuarios",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioID",
                table: "Telefonos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TelefonoContactoID",
                table: "Prestadoras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Prestadoras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MailContacto",
                table: "Prestadoras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Prestadoras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedicoID",
                table: "Licencias",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpleadoID",
                table: "Licencias",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioID",
                table: "Telefonos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Prestadoras_PrestadoraID",
                table: "Usuarios",
                column: "PrestadoraID",
                principalTable: "Prestadoras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
