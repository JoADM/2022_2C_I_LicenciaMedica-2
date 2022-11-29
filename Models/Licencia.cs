using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Licencia
    {
        public int LicenciaId { get; set; }

        public DateTime FechaSolicitud { get; set; }

        [Required(ErrorMessage = "Debe agregar una descripción")]
        public string Descripcion { get; set; }
        public int? EmpleadoId { get; set; }
        public int? MedicoId { get; set; }

        public Empleado? Empleado { get; set; }

        public Medico? Medico { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "Debe seleccionar una Fecha de Fin")]
        public DateTime FechaFin { get; set; }
        public bool Activa { get; set; }

    }
}
