using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LicenciaMedica.Data;
using _2022_2C_I_LicenciaMedica.Models;

namespace LicenciaMedica.Controllers
{
    public class LicenciasController : Controller
    {
        private readonly LicenciaMedicaContext _context;


        public LicenciasController(LicenciaMedicaContext context)
        {
            _context = context;

        }

        // GET: Licencias
        public async Task<IActionResult> Index()
        {
            var licenciaMedicaContext = _context.Licencias.Include(l => l.Empleado).Include(l => l.Medico);
            return View(await licenciaMedicaContext.ToListAsync());
        }

        // GET: Licencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Licencias == null)
            {
                return NotFound();
            }

            var licencia = await _context.Licencias
                .Include(l => l.Empleado)
                .Include(l => l.Medico)
                .FirstOrDefaultAsync(m => m.LicenciaId == id);
            if (licencia == null)
            {
                return NotFound();
            }

            return View(licencia);
        }

        // GET: Licencias/Create
        public IActionResult Create()
        {
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "UsuarioId", "Apellido");
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "UsuarioId", "Apellido");
            return View();
        }

        // POST: Licencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LicenciaId,FechaSolicitud,Descripcion,EmpleadoId,MedicoId,FechaInicio,FechaFin,Activa")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "UsuarioId", "Apellido", licencia.EmpleadoId);
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "UsuarioId", "Apellido", licencia.MedicoId);
            return View(licencia);
        }

        // GET: Licencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Licencias == null)
            {
                return NotFound();
            }

            var licencia = await _context.Licencias.FindAsync(id);
            if (licencia == null)
            {
                return NotFound();
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "UsuarioId", "Apellido", licencia.EmpleadoId);
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "UsuarioId", "Apellido", licencia.MedicoId);

            return View(licencia);
        }

        // POST: Licencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LicenciaId,FechaSolicitud,Descripcion,EmpleadoId,MedicoId,FechaInicio,FechaFin,Activa")] Licencia licencia)
        {
            if (id != licencia.LicenciaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenciaExists(licencia.LicenciaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "UsuarioId", "Apellido", licencia.EmpleadoId);
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "UsuarioId", "Apellido", licencia.MedicoId);
           
            return View(licencia);
        }

        // GET: Licencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Licencias == null)
            {
                return NotFound();
            }

            var licencia = await _context.Licencias
                .Include(l => l.Empleado)
                .Include(l => l.Medico)
                .FirstOrDefaultAsync(m => m.LicenciaId == id);
            if (licencia == null)
            {
                return NotFound();
            }

            return View(licencia);
        }

        // POST: Licencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Licencias == null)
            {
                return Problem("Entity set 'LicenciaMedicaContext.Licencias'  is null.");
            }
            var licencia = await _context.Licencias.FindAsync(id);
            if (licencia != null)
            {
                _context.Licencias.Remove(licencia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenciaExists(int id)
        {
            return _context.Licencias.Any(e => e.LicenciaId == id);
        }

        public IActionResult aniadirLicencia()
        {
            List<Usuario> usuarios = _context.Usuarios.ToList();
            ViewBag.usuarios = usuarios;


            ViewBag.MiUsuario = HttpContext.Session.GetString("usuarioId");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> aniadirLicencia([Bind("Descripcion,FechaInicio,FechaFin, EmpleadoId, MedicoId")] Licencia licencia)
        {
           
            Licencia lic = new Licencia();

            lic.FechaSolicitud = DateTime.Today;
            lic.Descripcion = licencia.Descripcion;
            lic.EmpleadoId = licencia.EmpleadoId;
            lic.FechaInicio = licencia.FechaInicio;
            lic.FechaFin = licencia.FechaFin;
            lic.Activa = true;


            lic.Empleado = _context.Empleados.FirstOrDefault(e => e.UsuarioId == licencia.EmpleadoId);

            lic.Medico = _context.Medicos.FirstOrDefault(e => e.UsuarioId == licencia.MedicoId);


            _context.Licencias.Add(lic);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
           

            return View(licencia);
        }


        public IActionResult MisLicencias()
        {
            var id = int.Parse(HttpContext.Session.GetString("usuarioId"));

            var licencias = (
                from p in _context.Licencias
                .Include(p => p.Empleado)
                .Where(x => x.EmpleadoId == id)
                .Include(p => p.Medico)
                orderby p.FechaSolicitud descending
              
                select p).ToList();
            return View(licencias);
        }

        public IActionResult MisVisitas()
        {
            ViewBag.medicoName = HttpContext.Session.GetString("nameMedico");


            var idUsuario = int.Parse(HttpContext.Session.GetString("usuarioId"));

            var medicos = (from p in _context.Medicos select p).ToList();

            var lstLicencia = (from p in _context.Licencias.Where(x => x.MedicoId == idUsuario) select p).ToList();

            List<string> lstNombres = new List<string>();

            for (int i = 0; i < lstLicencia.Count; i++)
            {
                var miLicencia = lstLicencia[i];
                var miEmpleado = (Usuario)(from p in _context.Usuarios.Where(x => x.UsuarioId == miLicencia.EmpleadoId) select p).ToList()[0];

                lstNombres.Add(miEmpleado.Nombre);

            }


            ViewBag.nombresEmpleados = lstNombres;
            return View(lstLicencia);


            //select * from Licencias
            //where LicenciaId = 1
        }

    }
}
