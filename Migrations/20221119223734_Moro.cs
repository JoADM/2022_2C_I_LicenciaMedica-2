using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenciaMedica.Migrations
{
    public partial class Moro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                          table: "Usuarios",
                          nullable: false
                                    );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
