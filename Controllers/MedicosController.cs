using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicenciaMedica.Models;
using LicenciaMedica.Data;
using Microsoft.EntityFrameworkCore;

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
            return View();
        }
    }
}
