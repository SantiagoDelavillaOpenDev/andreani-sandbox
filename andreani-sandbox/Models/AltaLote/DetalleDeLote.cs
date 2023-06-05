using System.ComponentModel.DataAnnotations;

namespace andreani_sandbox.Models.AltaLote;

public class DetalleDeLote
{ 
        [Required]
        [MaxLength(50)]
        public string articulo { get; set; }
        public string consumoAntesDe { get; set; }
        public string entregaAntesDe { get; set; }
        
        [MaxLength(50)]
        public string estadoDeUbicacionLote { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string estadoLote { get; set; }
        public string fechaFabricacion { get; set; }
        public string fechaVencimiento { get; set; }
       
        [Required]
        [MaxLength(50)]
        public string loteCaja { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string loteSecundario { get; set; }
        
        [MaxLength(50)]
        public string paquete { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string propietario { get; set; }
        
        [Required]
        [MaxLength(50)]
        public int trazable { get; set; }
        
        [MaxLength(50)]
        public int vidaUtil { get; set; }
        
        [MaxLength(128)]
        public string zonaConsumo { get; set; }
}