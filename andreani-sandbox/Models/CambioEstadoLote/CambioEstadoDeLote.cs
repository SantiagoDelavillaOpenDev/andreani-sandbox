using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.CambioEstadoLote;

public class CambioEstadoDeLote
{
    [Required]
    [MaxLength(50)]
    public string articulo { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string estadoLote { get; set; }
    
    public DateTime fechaVencimiento { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string loteCaja { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string loteSecundario { get; set; }
    
    [Required]
    [MaxLength(15)]
    public string propietario { get; set; }
}