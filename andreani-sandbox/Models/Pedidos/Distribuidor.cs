namespace andreani_sandbox.Models.Pedidos;

public class Distribuidor
{
    public List<DatosAdicionalesPedidos> datosAdicionales { get; set; }
    public string etiqueta { get; set; }
    public string nombre { get; set; }
    public string numeroDeEnvio { get; set; }
    public string remito { get; set; }
}