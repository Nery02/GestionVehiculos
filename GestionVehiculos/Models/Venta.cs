using System.ComponentModel.DataAnnotations;

public class Venta
{
    public int Id { get; set; }

    [Required]
    public double TotalVenta { get; set; }

    [Required]
    public int Cantidad { get; set; }

    // Relación muchos a uno con Vehículo
    public int VehiculoId { get; set; }
    public Vehiculo Vehiculo { get; set; }
}
