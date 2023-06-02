namespace andreani_sandbox.Models.CambioEstadoLote;

public class ErrorMessageCambioEstadoLote
{
    public string Detail { get; set; }
    public List<ErrorCambioEstadoLote> Errors { get; set; }
    public int Status { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}