namespace andreani_sandbox.Models.Facturacion;

public class RequestFacturacion
{
    public string Almacen { get; set; }
    public string ContratoDistribucion { get; set; }
    public string Instancia { get; set; }
    public PedidoFacturacion Pedido { get; set; }
}