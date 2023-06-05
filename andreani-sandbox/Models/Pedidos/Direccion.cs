using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Direccion
{
    [MaxLength(45)]
    public string calle { get; set; }
    
    [MaxLength(18)]
    public string codigoPostal { get; set; }
    
    [MaxLength(45)]
    public string departamento { get; set; }
    
    [MaxLength(45)]
    public string localidad { get; set; }
    
    [MaxLength(45)]
    public string numero { get; set; }
    
    [MaxLength(10)]
    public string pais { get; set; }
    
    [MaxLength(45)]
    public string piso { get; set; }
    
    [MaxLength(25)]
    public string provincia { get; set; }
    
    [MaxLength(45)]
    public string referenciaDeDomicilio { get; set; }
}