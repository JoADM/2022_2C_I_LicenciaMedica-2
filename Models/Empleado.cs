using LicenciaMedica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Empleado : Usuario
    {
        public int EmpleadoId { get; set; }
        public string ObraSocial { get; set; }
        public string Legajo { get; set; }
        public bool EmpleadoActivo { get; set; }
        public bool EmpleadoRRHH { get; set; }

        public virtual ICollection<Licencia> Licencia { get; set; }
    }
}
