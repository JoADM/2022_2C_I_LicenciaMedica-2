namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Licencia { 
        public DateTime FechaSolicitud { get; set; }
        public String Descripcion { get; set; }
        public Empleado Empleado { get; set; }
        public Visita[] Visitas { get; set; }

        public DateTime FechaInicioSolicitada { get; set; }

        public DateTime FechaFinSolicitada { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Boolean Activa { get; set; }
    }
}
