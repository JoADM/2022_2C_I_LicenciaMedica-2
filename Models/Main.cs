using _2022_2C_I_LicenciaMedica.Models;


namespace LicenciaMedica.Models
{
    public class Program
    {
        static void Main(String[] args) { 
           
            Institucion.agregar(new Empleado("1", "Joaquin", "Adamec", "44642076", "joaquin2003", "joaquinadamec2020@gmail.com", 19, "corrientes", "osde", "1234", true, false));
            Institucion.agregar(new Empleado("2", "Aldana", "Contreras", "12345", "joaquin2003", "joaquinadamec2020@gmail.com", 19, "corrientes", "osde", "1234", true, false));
            Institucion.agregar(new Empleado("3", "Nahuel", "Tamasso", "566746", "joaquin2003", "joaquinadamec2020@gmail.com", 19, "corrientes", "osde", "1234", true, false));
            Institucion.agregar(new Empleado("4", "Magali", "Said", "57484", "joaquin2003", "joaquinadamec2020@gmail.com", 19, "corrientes", "osde", "1234", true, false));

    }



    }
}
