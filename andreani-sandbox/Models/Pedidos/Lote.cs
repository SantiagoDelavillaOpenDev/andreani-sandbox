using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Lote
{
    [Required]
    [MaxLength(50)]
    public string estado { get; set; }
    
    public string fechaDeVencimiento { get; set; }
    
    [MaxLength(50)]
    public string loteDeFabricante { get; set; }
    
    [MaxLength(50)]
    public string loteSecundario { get; set; }
    
    public List<DatosAdicionalesPedidos> otrosDatos { get; set; }
}