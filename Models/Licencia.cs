namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Licencia
    {
        public int LicenciaId { get; set; }

        public string nombreMedico { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Descripcion { get; set; }
        public int? EmpleadoId { get; set; }
        public int? MedicoId { get; set; }
        public Empleado? Empleado { get; set; }
        public Medico? Medico { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activa { get; set; }

    }
}
