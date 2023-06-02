namespace andreani_sandbox.Models.Pedidos;

public class ErrorMessagePedidos
{
    public string Detail { get; set; }
    public List<ErrorPedidos> Errors { get; set; }
    public int Status { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}