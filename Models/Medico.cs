
namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Medico : Usuario
    {




        public int? PrestadoraId { get; set; }

        public string? Matricula { get; set; }

        public Prestadora? Prestadora { get; set; }


        public virtual ICollection<Licencia> Licencia { get; set; }

    }
}
