namespace andreani_sandbox.Models.Pedidos;

public class RequestPedidos
{
    public string almacen { get; set; }
    public string contratoDistribucion { get; set; }
    public string contratoWarehouse { get; set; }
    public string instancia { get; set; }
    public Pedido pedido { get; set; }
}