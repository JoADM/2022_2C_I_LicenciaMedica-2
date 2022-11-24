using _2022_2C_I_LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LicenciaMedica.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly LicenciaMedicaContext _context;

        public EmpleadosController(LicenciaMedicaContext context)
        {
            _context = context;
        }


        public IActionResult Empleados()
        {
            return View();
        }



        public async Task<IActionResult> aniadirLicencia([Bind("Descripcion,Empleado,Medico,FechaInicio,FechaFin")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                Licencia lic = new Licencia();

                lic.FechaSolicitud = DateTime.Today;
                lic.Descripcion = licencia.Descripcion;
                lic.Empleado = licencia.Empleado;
                lic.Medico = licencia.Medico;
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
