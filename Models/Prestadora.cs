using System.Collections;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Prestadora{
        public int PrestadoraId { get; set; }
        public string? Nombre { get; set; }
        public Telefono? TelefonoContacto { get; set; }
        public string? MailContacto { get; set; }
        //public Medico[] Medicos { get; set; }  
        public string? Direccion { get; set; }

        public Prestadora() { }
    }
}
