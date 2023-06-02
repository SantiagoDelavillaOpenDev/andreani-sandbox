using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class LoteAbastecimiento
{
    public List<DatosAdicionalesAbastecimiento> datosAdicionales { get; set; }
    
    [MaxLength(50)]
    public string estadoLote { get; set; }
    
    public string fechaDeVencimiento { get; set; }
    
    [MaxLength(50)]
    public string loteDeFabricante { get; set; }
    
    [MaxLength(50)]
    public string loteSecundario { get; set; }
}