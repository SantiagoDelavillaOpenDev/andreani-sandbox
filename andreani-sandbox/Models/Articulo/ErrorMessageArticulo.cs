namespace andreani_sandbox.Models.Articulo;

public class ErrorMessageArticulo
{
    public string Detail { get; set; }
    public List<ErrorArticulo> Errors { get; set; }
    public int Status { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}