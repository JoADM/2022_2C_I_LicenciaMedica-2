using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_LicenciaMedica.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }


        [Required(ErrorMessage = "Ingresa un nombre de usuario")]
        [StringLength(25,MinimumLength = 4, ErrorMessage = "El nombre de usuario debe tener entre 5 y 25 caracteres")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Ingresa un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingresa un apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingresa una direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Ingresa un DNI")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Ingrese una contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Ingrese un mail")] // Si esta vacio
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Ingresa una dirección de mail válida")]// si no hay @
        public string EMail { get; set; }

        [Required(ErrorMessage = "Ingresa un telefono")]
        public int? Telefono { get; set; }

        public int FechaAlta { get; set; }

        [Required(ErrorMessage = "Seleccione un rol")]
        public string Rol { get; set; }

    }
}
