using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class Abastecimiento
{
    public List<DatosAdicionalesAbastecimiento> datosAdicionales { get; set; }
    
    public string fechaDeRecepcionEsperada { get; set; }
    
    public string fechaOrdenExterna { get; set; }
    
    [Required]
    public List<LineaAbastecimiento> lineas { get; set; }
    
    [Required]
    [MaxLength(55)]
    public string numeroOrdenExterna { get; set; }
    
    [Required]
    public Origen origen { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string propietario { get; set; }
    
    [Required]
    public Transportista transportista { get; set; }
}