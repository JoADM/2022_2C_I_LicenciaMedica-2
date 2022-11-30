
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Medico : Usuario
    {





        //public Prestadora? Prestadora { get; set; }




        public int? PrestadoraId { get; set; }
        public string? Matricula { get; set; }

        public Prestadora? Prestadora { get; set; }


        public Medico() { }

        public virtual ICollection<Licencia> Licencia { get; set; }

    }
}
