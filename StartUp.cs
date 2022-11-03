namespace LicenciaMedica
{
    public static class Startup
    {
        public static WebApplication IniciarApp(string[] args)
        {
            //Crear nueva instancia de nuestro servidor web
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder); //Lo configuramos, con sus respectivos servicios

            var app = builder.Build(); // Sobre esta app configuraremos los middleware
            Configure(app); // Configuramos los middleWare

            return app;
        }
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Add services to the container.

            builder.Services.AddControllersWithViews();

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

            app.UseRouting();



            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
