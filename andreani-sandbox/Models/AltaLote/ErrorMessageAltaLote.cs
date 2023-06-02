namespace andreani_sandbox.Models.AltaLote;

public class ErrorMessageAltaLote
{
    public string Detail { get; set; }
    public List<ErrorAltaLote> Errors { get; set; }
    public int Status { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}