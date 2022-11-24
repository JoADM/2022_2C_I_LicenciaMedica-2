using _2022_2C_I_LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace LicenciaMedica.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly LicenciaMedicaContext _context;

        public EmpleadosController(LicenciaMedicaContext context)
        {
            _context = context;
        }


        public IActionResult aniadirLicencia()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> aniadirLicencia([Bind("Descripcion,FechaInicio,FechaFin")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                Licencia lic = new Licencia();

                lic.FechaSolicitud = DateTime.Today;
                lic.Descripcion = licencia.Descripcion;
                lic.Empleado = new Empleado();
                lic.Medico = new Medico();
                lic.FechaInicio = licencia.FechaInicio;
                lic.FechaFin = licencia.FechaFin;
                lic.Activa = true;

                _context.Licencias.Add(lic);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(licencia);
        }
    }
}
