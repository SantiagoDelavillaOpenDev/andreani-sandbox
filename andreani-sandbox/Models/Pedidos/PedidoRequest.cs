using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class PedidoRequest
{
    [Required]
    public string almacen { get; set; }
    
    [Required]
    public string contratoDistribucion { get; set; }
    
    [Required]
    public string contratoWarehouse { get; set; }
    
    [Required]
    public string instancia { get; set; }
    
    [Required]
    public Pedido pedido { get; set; }
}