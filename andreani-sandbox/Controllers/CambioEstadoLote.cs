

using andreani_sandbox.Models.CambioEstadoLote;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CambioEstadoLote.Controllers;

[ApiController]
[Route("/almacenes/lotes/cambioestadolote")]
[SwaggerTag("Cambio Estado Lote")]
public class CambioEstadoLoteController : ControllerBase
{
    /// <summary>
    /// Envio de solicitud de cambio de estado de lote
    /// </summary>
    /// <param name="cambioEstadoLote">Body para la solicitud de cambio de estado de lote</param>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="503">Service Unavailable</response>
    [ProducesResponseType(typeof(ResponseCambioEstadoLote), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorMessageCambioEstadoLote), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageCambioEstadoLote), StatusCodes.Status503ServiceUnavailable)]
    [HttpPost]
    public IActionResult Post(CambioEstadoLoteRequest cambioEstadoLote)
    {
        
        
        if (!ModelState.IsValid)
        {
            return BadRequest(new ErrorMessageCambioEstadoLote
            {
                Detail = "Error",
                Errors = new List<ErrorCambioEstadoLote>
                {
                    new ErrorCambioEstadoLote
                    {
                        Field = "string",
                        Message = "string"
                    }
                },
                Status = 400,
                Title = "string",
                Type = "Bad Request"
            });
        }
        
        Random random = new Random();
        int numeroAleatorio = random.Next(10000000, 99999999);

        var respuesta = new ResponseCambioEstadoLote
        {
            idTransaccion = numeroAleatorio
        };
        
        return Ok(respuesta);
    }
    
    /// <summary>
    /// Busqueda de una solicitud de cambio de estado de lote
    /// </summary>
    /// <param name="id">Id de transacción</param>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="404">Not Found</response>
    /// <response code="503">Service Unavailable</response>
    [ProducesResponseType(typeof(CambioEstadoLoteResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorMessageCambioEstadoLote), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageCambioEstadoLote), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorMessageCambioEstadoLote), StatusCodes.Status503ServiceUnavailable)]
    [HttpGet("{id}")]
     public IActionResult Get(int id)
     {
         if (!ModelState.IsValid)
         {
             return BadRequest(new ErrorMessageCambioEstadoLote
             {
                 Detail = "Error",
                 Errors = new List<ErrorCambioEstadoLote>
                 {
                     new ErrorCambioEstadoLote
                     {
                         Field = "string",
                         Message = "string"
                     }
                 },
                 Status = 400,
                 Title = "string",
                 Type = "Bad Request"
             });
         }

         if (id > 10000000 && id < 99999999)
         {
             return Ok(new CambioEstadoLoteResponse
             {
                 estado = "string",
                 fechaCreacion = "string",
                 fechaModificacion = "string",
                 razon = "string",
                 request = new CambioEstadoLoteRequest
                 {
                     almacen = "string",
                     cambioEstadoDeLote = new CambioEstadoDeLote
                     {
                         articulo = "string",
                         estadoLote = "string",
                         fechaVencimiento = DateTime.Now,
                         loteCaja = "string",
                         loteSecundario = "string",
                         propietario = "string",
                     },
                     instancia = "string",
                 },
                 response = new ResponseCambioEstadoLote
                 {
                     idTransaccion = id
                 }
             });
         }
         
         return NotFound(new ErrorMessageCambioEstadoLote
         {
             Detail = "Error",
             Errors = new List<ErrorCambioEstadoLote>
             {
                 new ErrorCambioEstadoLote
                 {
                     Field = "string",
                     Message = "No se ha encontrado el estado del lote"
                 }
             },
             Status = 404,
             Title = "string",
             Type = "Not Found"
         });
     }
    
}