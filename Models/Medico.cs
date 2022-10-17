﻿namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Medico : Usuario{
        public string Matricula { get; set; }
        public Prestadora Prestadora{ get; set; }
        public List<Licencia> Licencias { get; set; }

        public Medico(
            string iD, 
            string nombre, 
            string apellido, 
            string dNI, 
            string password, 
            string eMail, 
            DateTime fechaAlta,
            string matricula, 
            Prestadora prestadora
            )
        :base(iD, nombre, apellido, dNI, password, eMail, fechaAlta)
        {
            Matricula = matricula;
            Prestadora = prestadora;
            Licencias = new List<Licencia>();
        }
    }
}