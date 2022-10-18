using _2022_2C_I_LicenciaMedica.Models;

namespace LicenciaMedica.Models
{
    public  class Institucion
    {
     public static List<Usuario> empleados;
        public Institucion()
        {
            empleados = new List<Usuario>();
        }

        public static void agregar(Empleado e)
        {
            empleados.Add(e);
        }
        public async void mostrar(Empleado e){
            
        }

    }
}
