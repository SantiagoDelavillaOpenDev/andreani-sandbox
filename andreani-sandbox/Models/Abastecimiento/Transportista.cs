using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class Transportista
{
    public DatosPersonales datosPersonales { get; set; }
    
    [Required]
    [MaxLength(128)]
    public string idTransportista { get; set; }
}