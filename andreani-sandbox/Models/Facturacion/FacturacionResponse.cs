namespace andreani_sandbox.Models.Facturacion;

public class FacturacionResponse
{
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public string Razon { get; set; }
    public RequestFacturacion Request { get; set; }
    public ResponseFacturacion Response { get; set; }
}