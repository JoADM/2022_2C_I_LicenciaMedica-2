using LicenciaMedica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace LicenciaMedica
{
    public static class Startup
    {
        public static WebApplication IniciarApp(string[] args)
        {
            //Crear nueva instancia de nuestro servidor web
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder); //Lo configuramos, con sus respectivos servicios

            //builder.Services.AddDbContext<LicenciaMedicaContext>(options =>
            //{
            //options.UseSqlServer(builder.Configuration.GetConnectionString("LicenciaMedicaDBConnection"));
            //});

            var app = builder.Build(); // Sobre esta app configuraremos los middleware
            Configure(app); // Configuramos los middleWare

            return app;
        }
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<LicenciaMedicaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LicenciaMedicaDBConnection")));


            //Para la sesion
            builder.Services.AddDistributedMemoryCache();
            builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(100);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });




        }

        private static void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
