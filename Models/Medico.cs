
namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Medico : Usuario{

        


        public int PrestadoraId { get; set; }

        public string? Matricula { get; set; }
        
        //public int UsuarioLicencia { get; set; }-
        public Prestadora Prestadora{ get; set; }

        //public List<Licencia> Licencias { get; set; }

        public Medico() { }

/* public Medico(string nombre, string apellido, string dNI, string password,string eMail,int fechaAlta,string matricula ) 
    : base(nombre, apellido, dNI, password, eMail, fechaAlta)
{
    this.Matricula = matricula;
   // Licencia = new List<Licencia>();


}*/

public virtual ICollection<Licencia> Licencia { get; set; }

}
}
