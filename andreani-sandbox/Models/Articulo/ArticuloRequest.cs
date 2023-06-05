using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Articulo;

public class ArticuloRequest
{
    [Required]
    [MaxLength(30)]
    public string almacen { get; set; }
    
    public DetalleDeArticulo detalleDeArticulo { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string instancia { get; set; }
}