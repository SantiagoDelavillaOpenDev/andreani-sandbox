using System.ComponentModel.DataAnnotations;
using andreani_sandbox.Models.AltaLote;

namespace andreani_sandbox.Models.AltaLote;

public class LoteRequest
{
    [Required]
    public string almacen { get; set; }
    [Required]
    public DetalleDeLote detalleDeLote { get; set; }
    [Required]
    public string instancia { get; set; }
}