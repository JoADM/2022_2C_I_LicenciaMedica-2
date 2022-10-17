using System.Collections;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Prestadora{
        public String Nombre { get; set; }
        public Telefono TelefonoContacto { get; set; }
        public String MailContacto { get; set; }
        public Medico[] Medicos { get; set; }  
        public String Direccion { get; set; }
    }
}
