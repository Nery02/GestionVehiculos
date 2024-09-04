using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vehiculo
{
    public int Id { get; set; }

    [Required]
    public string Modelo { get; set; }

    [Required]
    public int Anio { get; set; }

    [Required]
    public int CantidadPuertas { get; set; }

    // Relación muchos a uno con Marca
    [ForeignKey("Marca")]
    public int MarcaId { get; set; }
    public Marca Marca { get; set; }
}
