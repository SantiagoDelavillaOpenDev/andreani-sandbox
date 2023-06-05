using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.Articulo;

namespace andreani_sandbox.Models;

public class DetalleDeArticulo
{
    public List<CamposLibresArticulo> camposLibres { get; set; }
    
    [MaxLength(25)]
    public string claseDeArticulo { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string codigo { get; set; }
    
    public string codigoDeVidaUtil { get; set; }
    
    [MaxLength(25)]
    public string coleccion { get; set; }
    
    [MaxLength(25)]
    public string color { get; set; }
    
    public string consumoEnDias { get; set; }
    
    [Required]
    public DatosLogisticosArticulo datosLogisticos { get; set; }
    
    [Required]
    [MaxLength(60)]
    public string descripcion { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string ean { get; set; }

    public string esNumeroDeSerieDeEntradaUnico { get; set; }
    
    public string esNumeroDeSerieSalidaUnico { get; set; }
    
    [MaxLength(25)]
    public string estilo { get; set; }
    
    [MaxLength(25)]
    public string finDeTemporada { get; set; }
    
    public List<GruposArticulo> grupos { get; set; }
    
    [MaxLength(10)]
    public string indicadorDeVidaUtil { get; set; }
    
    [MaxLength(25)]
    public string inicioDeTemporada { get; set; }
    
    [MaxLength(2000)]
    public string instruccionesDePreparacion { get; set; }
    
    [MaxLength(2000)]
    public string notas { get; set; }
    
    public List<OtrosDatosArticulo> otrosDatos { get; set; }
    
    [MaxLength(25)]
    public string paisDeOrigen { get; set; }
    
    [MaxLength(25)]
    public string pavu { get; set; }
    
    [Required]
    [MaxLength(15)]
    public string propietario { get; set; }
    
    [MaxLength(25)]
    public string psicotropico { get; set; }
    
    [MaxLength(128)]
    public string rubro { get; set; }
    
    [MaxLength(128)]
    public string serializado { get; set; }
    
    [MaxLength(25)]
    public string talle { get; set; }
    
    [MaxLength(25)]
    public string tema { get; set; }
    
    [MaxLength(25)]
    public string temperatura { get; set; }
    
    [MaxLength(25)]
    public string temporada { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string tipoEan { get; set; }
    
    public int vencimientoEnDias { get; set; }
    
    public string vidaUtilEntradaEnDias { get; set; }
    
    public string vidaUtilSalidaEnDias { get; set; }
}