using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.CambioEstadoLote;

namespace andreani_sandbox.Models.CambioEstadoLote;

public class CambioEstadoLoteRequest
{
    [Required]
    [MaxLength(30)]
    public string almacen { get; set; }
    
    [Required]
    public CambioEstadoDeLote cambioEstadoDeLote { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string instancia { get; set; }
}