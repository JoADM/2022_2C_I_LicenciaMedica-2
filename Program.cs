using Microsoft.Extensions.DependencyInjection.Extensions;
using LicenciaMedica;
using Microsoft.EntityFrameworkCore;
using LicenciaMedica.Data;

var builder = WebApplication.CreateBuilder(args);



var app = Startup.IniciarApp(args); //Pasamos los args q son recibidos en la ejecuci�n

app.Run();