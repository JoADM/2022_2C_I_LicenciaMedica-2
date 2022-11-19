using _2022_2C_I_LicenciaMedica.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenciaMedica.Data
{
    public class LicenciaMedicaContext : DbContext
    {

        public LicenciaMedicaContext(DbContextOptions options) : base(options)
        {
            //haskey, hasone, withmany, onModelCreating
        }


        //Tablas existentes
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<Prestadora> Prestadoras { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}