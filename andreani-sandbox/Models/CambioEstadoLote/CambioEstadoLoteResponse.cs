namespace andreani_sandbox.Models.CambioEstadoLote;

public class CambioEstadoLoteResponse
{
    public string estado { get; set; }
    public string fechaCreacion { get; set; }
    public string fechaModificacion { get; set; }
    public string razon { get; set; }
    public CambioEstadoLoteRequest request { get; set; }
    public ResponseCambioEstadoLote response { get; set; }
}