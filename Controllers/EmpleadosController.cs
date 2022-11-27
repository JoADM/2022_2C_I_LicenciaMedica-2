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

        
}
