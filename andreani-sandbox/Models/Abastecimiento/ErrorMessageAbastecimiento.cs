namespace andreani_sandbox.Models.Abastecimiento;

public class ErrorMessageAbastecimiento
{
    public string Detail { get; set; }
    public List<ErrorAbastecimiento> Errors { get; set; }
    public int Status { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}