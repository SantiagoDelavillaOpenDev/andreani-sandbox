using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class RequestPedidos
{
    [Required]
    [MaxLength(30)]
    public string almacen { get; set; }
   
    [Required]
    [MaxLength(20)]
    public string contratoDistribucion { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string contratoWarehouse { get; set; }
   
    [Required]
    [MaxLength(30)]
    public string instancia { get; set; }
    
    [Required]
    public Pedido pedido { get; set; }
}