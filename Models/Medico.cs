
namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Medico : Usuario
    {
        public int? MedicoId { get; set; }

        public virtual ICollection<Licencia>? Licencia { get; set; }

    }
}
