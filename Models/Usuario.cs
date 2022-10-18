namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Usuario{

        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public int FechaAlta { get; set; }

        public Usuario(
            string iD, 
            string nombre, 
            string apellido, 
            string dNI, 
            string password, 
            string eMail, 
            int fechaAlta
            )
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Password = password;
            EMail = eMail;
            Telefonos = new List<Telefono>();
            FechaAlta = fechaAlta;
        }
    }
}
