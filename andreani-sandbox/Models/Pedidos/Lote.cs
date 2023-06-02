using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Lote
{
    [Required]
    public string estado { get; set; }
    public string fechaDeVencimiento { get; set; }
    public string loteDeFabricante { get; set; }
    public string loteSecundario { get; set; }
    public List<DatosAdicionalesPedidos> otrosDatos { get; set; }
}