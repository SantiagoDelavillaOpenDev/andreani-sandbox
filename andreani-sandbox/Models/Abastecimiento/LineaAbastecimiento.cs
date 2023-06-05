using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class LineaAbastecimiento
{
    [MaxLength(128)]
    public List<string> accionControlCalidad { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string almacenWMS { get; set; }
    
    [Required]
    public ArticuloAbastecimiento articulo { get; set; }
    
    [MaxLength(30)]
    public string avisoContraMuestra { get; set; }
    
    [Required]
    public int cantidadPedida { get; set; }
    
    [MaxLength(20)]
    public string codigoAnmat { get; set; }
    
    [MaxLength(20)]
    public string contratoWarehouse { get; set; }
    
    public List<DatosAdicionalesAbastecimiento> datosAdicionales { get; set; }
    
    [MaxLength(50)]
    public string estatusOTdeTrazaporLPN { get; set; }
    
    [MaxLength(50)]
    public string estatusOtDeAcondporLpn { get; set; }
   
    [Required]
    [MaxLength(20)]
    public string numeroDeLinea { get; set; }
    
    [MaxLength(50)]
    public string productoTrazable { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string propietario { get; set; }
    
    [MaxLength(128)]
    public List<string> tipoAcondicionamiento { get; set; }
    
    [MaxLength(128)]
    public List<string> tipoControlCalidad { get; set; }
    
    [MaxLength(128)]
    public string tipoTraza { get; set; }
    
    [MaxLength(10)]
    public string ubicacionPredeterminada { get; set; }
    
    [MaxLength(10)]
    public string unidadMedida { get; set; }
    
    [MaxLength(128)]
    public string valorDeclarado { get; set; }
    
    [MaxLength(50)]
    public string vidaUtildelLote { get; set; }
}