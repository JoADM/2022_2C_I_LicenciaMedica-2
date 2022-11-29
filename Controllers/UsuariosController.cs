using _2022_2C_I_LicenciaMedica.Models;
using LicenciaMedica.Data;
using LicenciaMedica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

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

        public async Task<IActionResult> Registrar([Bind("NombreUsuario,Nombre,Apellido,Direccion,DNI,Password,EMail,Telefono,Rol")] Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                if (usuario.Rol == "medico")
                {
                    Medico nuevoMedico = new Medico();

                    nuevoMedico.NombreUsuario = usuario.NombreUsuario;
                    nuevoMedico.Nombre = usuario.Nombre;
                    nuevoMedico.Apellido = usuario.Apellido;
                    nuevoMedico.Direccion = usuario.Direccion;
                    nuevoMedico.DNI = usuario.DNI;
                    nuevoMedico.Password = usuario.Password;
                    nuevoMedico.EMail = usuario.EMail;
                    nuevoMedico.Telefono = usuario.Telefono;
                    nuevoMedico.Rol = usuario.Rol;

                    nuevoMedico.MedicoId = usuario.UsuarioId;

                    _context.Usuarios.Add(nuevoMedico);
                }

                if (usuario.Rol == "empleado" || usuario.Rol == "rrhh")
                {
                    Empleado nuevoEmpleado = new Empleado();

                    nuevoEmpleado.NombreUsuario = usuario.NombreUsuario;
                    nuevoEmpleado.Nombre = usuario.Nombre;
                    nuevoEmpleado.Apellido = usuario.Apellido;
                    nuevoEmpleado.Direccion = usuario.Direccion;
                    nuevoEmpleado.DNI = usuario.DNI;
                    nuevoEmpleado.Password = usuario.Password;
                    nuevoEmpleado.EMail = usuario.EMail;
                    nuevoEmpleado.Telefono = usuario.Telefono;
                    nuevoEmpleado.Rol = usuario.Rol;
                    nuevoEmpleado.EmpleadoActivo = true;

                    if (usuario.Rol == "rrhh")
                    {
                        nuevoEmpleado.EmpleadoRRHH = true;
                    }

                    _context.Usuarios.Add(nuevoEmpleado);
                }

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
            var u = _context.Usuarios.FirstOrDefault(x => x.NombreUsuario == ususarioRegister && x.Password == contraseniaRegister);

            if (u == null)
            {
                TempData["mensaje"] = "El usuario o contraseña ingresados son incorrectos";
                return RedirectToAction("IniciarSesion");
            }

            HttpContext.Session.SetString("usuario", u.NombreUsuario);
            HttpContext.Session.SetString("rol", u.Rol);
            if (u.Rol == "medico")
            {
                HttpContext.Session.SetString("nameMedico", u.Nombre);
            }

            if (u.Rol == "empleado")
            {
                HttpContext.Session.SetString("nameEmpleado", u.Nombre);
            }

            HttpContext.Session.SetString("usuarioId", u.UsuarioId.ToString());

            /*HttpContext.Session.SetString("rol", u.Rol);*/

            //TIENE QUE RETORNAR A LA PAGINA DEL USUARIO QUE SEA      
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> IniciarSesion()
        {
            TempData["mensaje"] = TempData["mensaje"];
            return View();
        }

        public async Task<IActionResult> Logout()
        {

            HttpContext.Session.Remove("usuario");
            HttpContext.Session.Remove("nombreUsuario");
            HttpContext.Session.Remove("password");
            HttpContext.Session.Remove("usuarioID");


            return RedirectToAction("Index", "Home");
        }
    }
}
