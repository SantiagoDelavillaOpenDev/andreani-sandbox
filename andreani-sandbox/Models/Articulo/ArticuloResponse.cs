namespace andreani_sandbox.Models.Articulo;

public class ArticuloResponse
{
    public string estado { get; set; }
    public string fechaCreacion { get; set; }
    public string fechaModificacion { get; set; }
    public string razon { get; set; }
    public ArticuloRequest request { get; set; }
    public ResponseArticulo response { get; set; }
}