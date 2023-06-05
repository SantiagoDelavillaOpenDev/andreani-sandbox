using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Linea
{
    [MaxLength(128)]
    public string admitePickingParcial { get; set; }
    
    [Required]
    public Articulo articulo { get; set; }
    
    [Required]
    public string contratoWarehouse { get; set; }
    
    public int diasVencimientoMinimo { get; set; }
    
    [MaxLength(128)]
    public string estatusOtDeAcondi { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string numeroDeLinea { get; set; }
    
    [MaxLength(255)]
    public string tipoDeAcondicionamientoSecundario { get; set; }
    
    public List<int> tiposDeAcondicionamientoSecundario { get; set; }
}
