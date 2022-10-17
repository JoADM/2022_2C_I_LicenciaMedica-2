namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Visita{
        public Licencia Licencia { get; set; }
        public Medico Medico { get; set; }   
        public DateTime FechaYHoraVisita { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin{ get; set; }

        public String Descripcion { get; set; }
        public Boolean Justificada { get; set; }
        public int CantDias { get; set; }
        public String Nota { get; set; }  

        public Boolean Cargada { get; set; }



    }
}
