using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class DatosPersonales
{
    [MaxLength(128)]
    public string email { get; set; }
    
    [MaxLength(128)]
    public string nombreCompleto { get; set; }
    
    [MaxLength(128)]
    public string numeroDeDocumento { get; set; }
    
    [MaxLength(128)]
    public string tipoDeDocumento { get; set; }
}