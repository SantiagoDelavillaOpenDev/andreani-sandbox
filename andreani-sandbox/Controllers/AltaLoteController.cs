using andreani_sandbox.Models.AltaLote;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace andreani_sandbox.Controllers;

[ApiController]
[Route("/almacenes/lotes")]
[SwaggerTag("Alta Lote")]
public class AltaLoteController : ControllerBase
{
    /// <summary>
    /// Envía una solicitud de alta de lote
    /// </summary>
    /// <param name="lote">Lote que se añadirá</param>
    /// <response code="202">Accepted</response>
    /// <response code="400">Bad Request</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="503">Service Unavailable</response>
    [ProducesResponseType(typeof(ResponseAltaLote), StatusCodes.Status202Accepted)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status503ServiceUnavailable)]

    [HttpPost]
    public IActionResult Post([FromBody]LoteRequest lote)
    {
        string authorizationHeader = HttpContext.Request.Headers["Authorization"];

        if (authorizationHeader == "<API_KEY_VALUE>" || authorizationHeader == null)
        {
            return Unauthorized(new ErrorMessageAltaLote
            {
                Detail = "Error",
                Errors = new List<ErrorAltaLote>
                {
                    new ErrorAltaLote
                    {
                        Field = "string",
                        Message = "string"
                    }
                },
                Status = 401,
                Title = "string",
                Type = "Unauthorized"
            });
        }
        
        if (!ModelState.IsValid)
        {
            return BadRequest(new ErrorMessageAltaLote
            {
                Detail = "Error",
                Errors = new List<ErrorAltaLote>
                {
                    new ErrorAltaLote
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
        
        var respuesta = new
        { 
            idTransaccion = numeroAleatorio
        };
        
        return Ok(respuesta);
    }

    /// <summary>
    /// Consulta de Solicitud de un alta de lote
    /// </summary>
    /// <param name="idTransaccion">Id del lote</param>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="404">Not Found</response>
    /// <response code="500">Internal Server Error</response>
    [ProducesResponseType(typeof(LoteResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorMessageAltaLote), StatusCodes.Status500InternalServerError)]
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        string authorizationHeader = HttpContext.Request.Headers["Authorization"];

        if (authorizationHeader == "<API_KEY_VALUE>" || authorizationHeader == null)
        {
            return Unauthorized(new ErrorMessageAltaLote
            {
                Detail = "Error",
                Errors = new List<ErrorAltaLote>
                {
                    new ErrorAltaLote
                    {
                        Field = "string",
                        Message = "string"
                    }
                },
                Status = 401,
                Title = "string",
                Type = "Unauthorized"
            });
        }
        
        if (!ModelState.IsValid)
        {
            return BadRequest(new ErrorMessageAltaLote
            {
                Detail = "Error",
                Errors = new List<ErrorAltaLote>
                {
                    new ErrorAltaLote
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
            return Ok(new LoteResponse
            {
                Estado = "PENDIENTE",
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Razon = "",
                Request = new LoteRequest
                {
                    almacen = "string",
                    instancia = "string",
                    detalleDeLote = new DetalleDeLote
                    {
                        articulo = "string",
                        consumoAntesDe = "string",
                        entregaAntesDe = "string",
                        estadoDeUbicacionLote = "string",
                        estadoLote = "string",
                        fechaFabricacion = "string",
                        fechaVencimiento = "string",
                        loteCaja = "string",
                        loteSecundario = "string",
                        paquete = "string",
                        propietario = "string",
                        trazable = 0,
                        vidaUtil = 0,
                        zonaConsumo = "string"
                    }
                },
                Response = new ResponseAltaLote
                {
                    idTransaccion = id
                }
            });
        }

        return NotFound(new ErrorMessageAltaLote
        {
            Detail = "Error",
            Errors = new List<ErrorAltaLote>
            {
                new ErrorAltaLote
                {
                    Field = "string",
                    Message = "No se ha encontrado el lote"
                }
            },
            Status = 404,
            Title = "string",
            Type = "Not Found"
        });
    }

    
}