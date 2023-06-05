using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.Pedidos;

public class Destinatario
{
    [MaxLength(30)]
    public string contacto { get; set; }
    
    [Required]
    public Direccion direccion { get; set; }
    
    [MaxLength(55)]
    public string email { get; set; }
    
    [Required]
    [MaxLength(15)]
    public string idDestinatario { get; set; }
    
    [MaxLength(15)]
    public string idInternoCliente { get; set; }
   
    [MaxLength(45)]
    public string nombreCompleto { get; set; }
    
    [MaxLength(45)]
    public string numeroDeDocumento { get; set; }
   
    [MaxLength(18)]
    public string telefono { get; set; }
   
    [MaxLength(18)]
    public string tipoDeDocumento { get; set; }
}