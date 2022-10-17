using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicenciaMedica.Models;

namespace LicenciaMedica.Controllers
{
    public class MedicosController : Controller
{
    public IActionResult Medicos()
    {
        return View();
    }
}
}
