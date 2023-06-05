using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Articulo
{
    [Required]
    public int cantidad { get; set; }
    
    [Required]
    [MaxLength(55)]
    public string codigo { get; set; }
    
    [Required]
    public Lote lote { get; set; }
    
    [MaxLength(50)]
    public string numeroDePedido { get; set; }
    
    [Required]
    [MaxLength(12)]
    public string propietario { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string unidadDeMedida { get; set; }
    
    [MaxLength(55)]
    public string zonaConsumo { get; set; }
}
