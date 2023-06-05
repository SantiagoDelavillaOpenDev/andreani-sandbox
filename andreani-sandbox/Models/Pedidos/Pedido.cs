using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.Pedidos;

namespace andreani_sandbox.Models.Pedidos;

public class Pedido
{
    [Required]
    [MaxLength(30)]
    public string almacenCliente { get; set; }
    public List<ArchivoRemito> archivoRemito { get; set; }
    
    [MaxLength(128)]
    public string cambioLoteDirigido { get; set; }
    
    [MaxLength(128)]
    public string cot { get; set; }
    
    public List<DatosAdicionalesPedidos> datosAdicionales { get; set; }
    
    [Required]
    public Destinatario destinatario { get; set; }
    
    [Required]
    public Distribuidor distribuidor { get; set; }
    
    [MaxLength(128)]
    public string estatusOtDeTraza { get; set; }
    
    [MaxLength(128)]
    public string facturaLegal { get; set; }
    
    public string fechaDeExpedicionSolicitada { get; set; }
    
    public string fechaDeFacturacion { get; set; }
    
    public string fechaEntrega { get; set; }
    
    [Required]
    public string fechaPedido { get; set; }
    
    [MaxLength(128)]
    public string franjaHoraria { get; set; }
    
    [Required]
    public List<Linea> lineas { get; set; }
    
    public List<LinkImpresionRemito> linkImpresionRemito { get; set; }
    
    [MaxLength(128)]
    public string marketPlace { get; set; }
    
    [MaxLength(128)]
    public string notas { get; set; }
    
    [Required]
    [MaxLength(55)]
    public string numeroOrdenExterna { get; set; }
    
    [MaxLength(50)]
    public string ordenCompra { get; set; }
    
    [MaxLength(128)]
    public string precioValorFc { get; set; }
    
    [Required]
    [MaxLength(55)]
    public string propietario { get; set; }
    
    [MaxLength(55)]
    public string remito { get; set; }
    
    [MaxLength(128)]
    public string tieneGestionCobranza { get; set; }
    
    [MaxLength(128)]
    public string valorDeclarado { get; set; }
}
