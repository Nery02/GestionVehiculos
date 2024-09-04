using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GestionVehiculos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


           app.MapControllerRoute(
                name: "ventas",
                pattern: "Venta/{action=Index}/{id?}",
                defaults: new { controller = "Ventas" });

            app.MapControllerRoute(
                name: "vehiculos",
                pattern: "Vehiculo/{action=Index}/{id?}",
                defaults: new { controller = "Vehiculos" });

            app.MapControllerRoute(
                name: "marcas",
                pattern: "Marca/{action=Index}/{id?}",
                defaults: new { controller = "Marcas" });

            app.Run();
        }
    }
}
