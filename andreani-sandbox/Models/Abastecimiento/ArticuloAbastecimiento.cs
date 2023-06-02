using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class ArticuloAbastecimiento
{
    [Required]
    [MaxLength(50)]
    public string codigo { get; set; }
    
    public List<DatosAdicionalesAbastecimiento> datosAdicionales { get; set; }
    
    [Required]
    public LoteAbastecimiento lote { get; set; }
}