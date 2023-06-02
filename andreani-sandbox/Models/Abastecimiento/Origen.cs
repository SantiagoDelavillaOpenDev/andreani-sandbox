using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Abastecimiento;

public class Origen
{
    [MaxLength(45)]
    public string calle { get; set; }
    
    [MaxLength(18)]
    public string codigoPostal { get; set; }
    
    public List<DatosAdicionalesAbastecimiento> datosAdicionales { get; set; }
    
    [MaxLength(45)]
    public string departamento { get; set; }
    
    [MaxLength(45)]
    public string id { get; set; }
    
    [MaxLength(45)]
    public string localidad { get; set; }
    
    [MaxLength()]
    public string nombreProvincia { get; set; }
    
    [MaxLength(45)]
    public string numero { get; set; }
    
    [MaxLength(45)]
    public string piso { get; set; }
}