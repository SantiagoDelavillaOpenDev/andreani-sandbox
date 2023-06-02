using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Facturacion;

public class FacturacionRequest
{
    [Required]
    public string Almacen { get; set; }
    [Required]
    public string ContratoDistribucion { get; set; }
    [Required]
    public string Instancia { get; set; }
    [Required]
    public PedidoFacturacion Pedido { get; set; }
}