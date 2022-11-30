using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Licencia
    {
        public int LicenciaId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Descripcion { get; set; }
        public int? EmpleadoId { get; set; }
        public int? MedicoId { get; set; }
        public Empleado? Empleado { get; set; }
        public Medico? Medico { get; set; }

        [Display(Name = "Fecha de inicio")]

        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de fin")]

        public DateTime FechaFin { get; set; }

        [Display(Name = "Está activa")]

        public bool Activa { get; set; }

    }
}
