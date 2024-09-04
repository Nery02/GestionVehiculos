using Microsoft.EntityFrameworkCore;
using GestionVehiculos.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Venta> Ventas { get; set; }
}
