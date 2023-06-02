namespace andreani_sandbox.Models.Abastecimiento;

public class RequestAbastecimiento
{
    public andreani_sandbox.Models.Abastecimiento.Abastecimiento abastecimiento { get; set; }
    public string almacen { get; set; }
    public string contratoDistribucion { get; set; }
    public string contratoWarehouse { get; set; }
    public string instancia { get; set; }
}