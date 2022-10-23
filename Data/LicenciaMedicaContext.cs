using _2022_2C_I_LicenciaMedica.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenciaMedica.Data
{
    public class LicenciaMedicaContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<Prestadora> Prestadoras { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LicenciaMedicaDB;Trusted_Connection=True;");
        }
    }
}
