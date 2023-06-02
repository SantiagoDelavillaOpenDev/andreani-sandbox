namespace andreani_sandbox.Models.Abastecimiento;

public class AbastecimientoResponse
{
    public string estado { get; set; }
    public string fechaCreacion { get; set; }
    public string fechaModificacion { get; set; }
    public string razon { get; set; }
    public RequestAbastecimiento request { get; set; }
    public ResponseAbastecimiento response { get; set; }
}