using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Distribuidor
{
    public List<DatosAdicionalesPedidos> datosAdicionales { get; set; }
   
    [MaxLength(50)]
    public string etiqueta { get; set; }
    
    [MaxLength(50)]
    public string nombre { get; set; }
    
    [MaxLength(50)]
    public string numeroDeEnvio { get; set; }
    
    [MaxLength(50)]
    public string remito { get; set; }
}