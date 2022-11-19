using System.ComponentModel.DataAnnotations.Schema;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Usuario {
    
        public int ID { get; set; }

        [NotMapped]
        public string? NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string DNI { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public int? Telefono { get; set; }
        public int FechaAlta { get; set; }

        public Usuario() { }

        /* public Usuario(
             string nombre, 
             string apellido, 
             string dNI, 
             string password, 
             string eMail, 
             int fechaAlta
             )
         {
             Nombre = nombre;
             Apellido = apellido;
             DNI = dNI;
             Password = password;
             EMail = eMail;
             Telefonos = new List<Telefono>();
             FechaAlta = fechaAlta;
         }
     */
    }
}
