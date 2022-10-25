using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Empleado : Usuario{

        public string Direccion { get; set; }
        public string ObraSocial { get; set; }
        public string Legajo { get; set; }
        public bool EmpleadoActivo { get; set; }
        public bool EmpleadoRRHH { get; set; }
        public List<Licencia> Licencias { get; set; }

        public Empleado( 
            string nombre, 
            string apellido, 
            string dNI, 
            string password, 
            string eMail, 
            int fechaAlta, 
            string direccion, 
            string obraSocial, 
            string legajo,
            bool empleadoActivo,
            bool empleadoRRHH
            )
            :base(nombre, apellido, dNI, password, eMail, fechaAlta)
        {
            Direccion = direccion;
            ObraSocial = obraSocial;
            Legajo = legajo;
            EmpleadoActivo = empleadoActivo;
            EmpleadoRRHH = empleadoRRHH;
            Licencias = new List<Licencia>();
        }
    }
}
