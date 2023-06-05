using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.AltaLote;

namespace andreani_sandbox.Models.AltaLote;

public class LoteRequest
{
    [Required]
    [MaxLength(30)]
    public string almacen { get; set; }
    
    [Required]
    public DetalleDeLote detalleDeLote { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string instancia { get; set; }
}