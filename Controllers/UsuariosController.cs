using _2022_2C_I_LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace LicenciaMedica.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly LicenciaMedicaContext _context;

        public UsuariosController(LicenciaMedicaContext context)
        {
            _context = context;
        }

        public IActionResult Registrar()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public async Task<IActionResult> Registrar([Bind("NombreUsuario,Nombre,Apellido,Direccion," +

            "DNI,Password,EMail,Telefono,FechaAlta,Rol")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if(usuario.Rol == "medico")
                {
                    Medico nuevoMedico = new Medico();
                    nuevoMedico.Apellido = usuario.Apellido;
                    nuevoMedico.Direccion = usuario.Direccion;
                    _context.Add(nuevoMedico);// Agrega usuario a la base de datos

                }

                if (usuario.Rol == "empleado")
                {
                    Medico nuevoMedico = new Empleado();
                    nuevoMedico.Apellido = usuario.Apellido;
                    nuevoMedico.Direccion = usuario.Direccion;
                    _context.Add(empleado);// Agrega usuario a la base de datos

                }
                /*
                switch (usuario.Rol)
                {
                    case "MEDICO":
                        _context.Add((Medico)usuario);
                        break;

                    case "RRHH":
                    case "Empleado":
                        if(usuario.Rol == "RRHH")
                        {
                            ((Empleado)usuario).EmpleadoRRHH = true;
                        }
                        else
                        {
                            ((Empleado)usuario).EmpleadoRRHH = false;
                        }

                        //((Empleado)usuario).EmpleadoRRHH = (usuario.Rol == "RRHH");
                        _context.Add((Empleado)usuario);
                        break;

                    default:
                        break;
                }*/
                //TODO: Ver como hacer autoincremental el ID



                _context.Add(usuario);// Agrega usuario a la base de datos
                await _context.SaveChangesAsync(); // Espera
                return RedirectToAction("Index", "Home");// Te redirige
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoggearUsuario(string ususarioRegister, string contraseniaRegister)
        {
            //Valida que exista el usuario
            var u = _context.Usuarios.Where(x => x.Nombre == ususarioRegister && x.Password == contraseniaRegister).FirstOrDefault();

            if (u == null)
            {
                TempData["mensaje"] = "El usuario o contraseña ingresados son incorrectos";
                return RedirectToAction("Login");

            }

            HttpContext.Session.SetString("usuario", u.Nombre);


            /*HttpContext.Session.SetString("rol", u.Rol);*/

            //TIENE QUE RETORNAR A LA PAGINA DEL USUARIO QUE SEA      
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> IniciarSesion()
        {
            TempData["mensaje"] = TempData["mensaje"];
            return View();
        }
    }
}
