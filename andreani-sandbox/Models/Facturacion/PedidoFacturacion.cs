using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.Facturacion;
using andreani_sandbox.Models.Pedidos;

namespace andreani_sandbox.Models.Facturacion;

public class PedidoFacturacion
{
    public string ArchivoImpresionRemito { get; set; }
    public string Cot { get; set; }
    public List<DatosAdicionalesFacturacion> DatosAdicionales { get; set; }
    public string FacturaLegal { get; set; }
    public string FechaDeFacturacion { get; set; }
    public string FechaEntrega { get; set; }
    public string LinkImpresionRemito { get; set; }
    [Required]
    public string NumeroOrdenExterna { get; set; }
    public string PrecioValorFc { get; set; }
    [Required]
    public string Propietario { get; set; }
    public string Remito { get; set; }
    public string TieneGestionCobranza { get; set; }
    public string ValorDeclarado { get; set; }
}