using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class RequestAbastecimiento
{
    [Required]
    public Abastecimiento abastecimiento { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string almacen { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string contratoDistribucion { get; set; }
    
    [MaxLength(20)]
    public string contratoWarehouse { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string instancia { get; set; }
}