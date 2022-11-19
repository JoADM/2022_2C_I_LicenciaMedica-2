using _2022_2C_I_LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.AspNetCore.Mvc;

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

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        //Se saco nombreUsuario, pero hay que agregarlo
        public async Task<IActionResult> Registrar([Bind("Password,Nombre,Apellido,DNI,Telefono,Direccion,FechaAlta,EMail")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);// Agrega usuario a la base de datos
                await _context.SaveChangesAsync(); // Espera
                return RedirectToAction("Index", "Home");// Te redirige
            }
            return View(usuario);
        }
    }
}
