using System;

namespace andreani_sandbox.Models.AltaLote;

public class LoteResponse
{
    public string Estado { get; set; } 
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public string Razon { get; set; } 
    public LoteRequest Request { get; set; }
    public ResponseAltaLote Response { get; set; } 
}