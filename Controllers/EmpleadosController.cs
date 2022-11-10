using Microsoft.AspNetCore.Mvc;

namespace LicenciaMedica.Controllers
{
    public class EmpleadosController : Controller
    {
        public IActionResult Empleados()
        {
            return View();
        }
    }
}
