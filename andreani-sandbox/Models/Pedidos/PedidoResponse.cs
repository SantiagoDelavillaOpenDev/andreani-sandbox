namespace andreani_sandbox.Models.Pedidos;

public class PedidoResponse
{
    public string estado { get; set; }
    public DateTime fechaCreacion { get; set; }
    public DateTime fechaModificacion { get; set; }
    public string razon { get; set; }
    public RequestPedidos request { get; set; }
    public ResponsePedidos response { get; set; }
}