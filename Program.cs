using Microsoft.Extensions.DependencyInjection.Extensions;
using LicenciaMedica;

var builder = WebApplication.CreateBuilder(args);

var app = Startup.IniciarApp(args); //Pasamos los args q son recibidos en la ejecución

app.Run();
