using _2022_2C_I_LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;


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
            List<Usuario> usuarios = _context.Usuarios.ToList();
            ViewBag.usuarios = usuarios;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> aniadirLicencia([Bind("Descripcion,FechaInicio,FechaFin,Medico")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {


                Licencia lic = new Licencia();

                lic.FechaSolicitud = DateTime.Today;
                lic.Descripcion = licencia.Descripcion;
                lic.Empleado = new Empleado();
                lic.Medico = licencia.Medico;
                lic.FechaInicio = licencia.FechaInicio;
                lic.FechaFin = licencia.FechaFin;
                lic.Activa = true;

                //Prueba para la BBDD
                //lic.EmpleadoId = 1;
                //lic.MedicoId = 1;

                _context.Licencias.Add(lic);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(licencia);
        }
    }
}
