using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.Facturacion;
using andreani_sandbox.Models.Pedidos;

namespace andreani_sandbox.Models.Facturacion;

public class PedidoFacturacion
{
    
    [MaxLength(128)]
    public string ArchivoImpresionRemito { get; set; }
    
    [MaxLength(128)]
    public string Cot { get; set; }
    
    public List<DatosAdicionalesFacturacion> DatosAdicionales { get; set; }
    
    [MaxLength(128)]
    public string FacturaLegal { get; set; }
    
    public string FechaDeFacturacion { get; set; }
    
    public string FechaEntrega { get; set; }
   
    [MaxLength(128)]
    public string LinkImpresionRemito { get; set; }
    
    [Required]
    [MaxLength(55)]
    public string NumeroOrdenExterna { get; set; }
    
    [MaxLength(128)]
    public string PrecioValorFc { get; set; }
    
    [Required]
    [MaxLength(55)]
    public string Propietario { get; set; }
    
    [MaxLength(55)]
    public string Remito { get; set; }
    
    [MaxLength(128)]
    public string TieneGestionCobranza { get; set; }
    
    [MaxLength(128)]
    public string ValorDeclarado { get; set; }
}