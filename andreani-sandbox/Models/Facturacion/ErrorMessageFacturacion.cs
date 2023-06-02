namespace andreani_sandbox.Models.Facturacion;

public class ErrorMessageFacturacion
{ 
    public string Detail { get; set; }
    public List<ErrorFacturacion> Errors { get; set; }
    public int Status { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}