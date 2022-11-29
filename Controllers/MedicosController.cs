using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.EntityFrameworkCore;
using _2022_2C_I_LicenciaMedica.Models;

namespace LicenciaMedica.Controllers
{
    public class MedicosController : Controller
    {

        private readonly LicenciaMedicaContext _context;
        public MedicosController(LicenciaMedicaContext context)
        {
            _context = context;
        }

        public IActionResult Medicos()
        {
            ViewBag.medicoName = HttpContext.Session.GetString("nameMedico");


            var idUsuario = int.Parse(HttpContext.Session.GetString("usuarioId"));

            var medicos = (from p in _context.Medicos select p).ToList();

            var lstLicencia = (from p in _context.Licencias.Where(x => x.MedicoId == idUsuario) select p).ToList();

            List<string> lstNombres = new List<string>(); 

            for (int i = 0; i < lstLicencia.Count; i++)
            {
                var miLicencia = lstLicencia[i];
                var miEmpleado  = (Usuario)(from p in _context.Usuarios.Where(x => x.UsuarioId == miLicencia.EmpleadoId) select p).ToList()[0];

               lstNombres.Add(miEmpleado.Nombre);

            }

       
            ViewBag.nombresEmpleados = lstNombres;
            return View(lstLicencia);


            //select * from Licencias
            //where LicenciaId = 1
        }
    }
}
