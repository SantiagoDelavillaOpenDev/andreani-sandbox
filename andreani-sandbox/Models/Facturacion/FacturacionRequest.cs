using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Facturacion;

public class FacturacionRequest
{
    [Required]
    [MaxLength(10)]
    public string Almacen { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string ContratoDistribucion { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string Instancia { get; set; }
    
    [Required]
    public PedidoFacturacion Pedido { get; set; }
}