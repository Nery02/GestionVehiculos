using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Marca
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    // Relación de uno a muchos con Vehículo
    public List<Vehiculo> Vehiculos { get; set; }
}
