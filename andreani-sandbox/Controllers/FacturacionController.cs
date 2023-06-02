using andreani_sandbox.Models.Facturacion;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace andreani_sandbox.Controllers;

[ApiController]
[Route("facturacion")]
[SwaggerTag("Facturacion")]
public class FacturacionController : ControllerBase
{
     /// <summary>
    /// Datos de facturación
    /// </summary>
     /// <param name="facturacion">Servicio generacion del evento de Datos Facturacion solicitada para el consumo de SCE</param>
     /// <response code="202">Accepted</response>
     /// <response code="400">Bad Request</response>
     /// <response code="500">Internal Server Error</response>
     [ProducesResponseType(typeof(ResponseFacturacion), StatusCodes.Status202Accepted)]
     [ProducesResponseType(typeof(ErrorMessageFacturacion), StatusCodes.Status400BadRequest)]
     [ProducesResponseType(typeof(ErrorMessageFacturacion), StatusCodes.Status500InternalServerError)]
     
     [HttpPost]
    public IActionResult Post(FacturacionRequest facturacion)
     {
         if (!ModelState.IsValid)
         {
             return BadRequest(new ErrorMessageFacturacion
             {
                 Detail = "Error",
                 Errors = new List<ErrorFacturacion>
                 {
                     new ErrorFacturacion
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

         var respuesta = new ResponseFacturacion
         {
             idTransaccion = numeroAleatorio
         };
        
         return StatusCode(202, respuesta);
     }
     
     /// <summary>
     /// Transacción de Datos de Facturación
     /// </summary>
     /// <param name="facturacion">Servicio de consulta del estado de Datos facturacion Solicitada</param>
     /// <response code="202">Accepted</response>
     /// <response code="400">Bad Request</response>
     /// <response code="404">Not Found</response>
     /// <response code="500">Internal Server Error</response>
     [ProducesResponseType(typeof(FacturacionResponse), StatusCodes.Status202Accepted)]
     [ProducesResponseType(typeof(ErrorMessageFacturacion), StatusCodes.Status400BadRequest)]
     [ProducesResponseType(typeof(ErrorMessageFacturacion), StatusCodes.Status404NotFound)]
     [ProducesResponseType(typeof(ErrorMessageFacturacion), StatusCodes.Status500InternalServerError)]
    
     [HttpGet("{id}")]
     public IActionResult Get(int id)
     {
         if (!ModelState.IsValid)
         {
             return BadRequest(new ErrorMessageFacturacion
             {
                 Detail = "Error",
                 Errors = new List<ErrorFacturacion>
                 {
                     new ErrorFacturacion
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
             return Accepted(new FacturacionResponse
             {
                 Estado = "PENDIENTE",
                 FechaCreacion = DateTime.Now,
                 FechaModificacion = DateTime.Now,
                 Razon = "",
                 Request = new RequestFacturacion
                 {
                     Almacen = "string",
                     Instancia = "string",
                     ContratoDistribucion = "string",
                     Pedido = new PedidoFacturacion
                     {
                         ArchivoImpresionRemito = "string",
                         Cot = "string",
                         DatosAdicionales = new List<DatosAdicionalesFacturacion>
                         {
                             new DatosAdicionalesFacturacion
                             {
                                 Contenido = "string",
                                 Meta = "string"
                             }
                         },
                         FacturaLegal = "string",
                         FechaDeFacturacion = "string",
                         FechaEntrega =  "string",
                         LinkImpresionRemito =  "string",
                         NumeroOrdenExterna =  "string",
                         PrecioValorFc =  "string",
                         Propietario =  "string",
                         Remito =  "string",
                         TieneGestionCobranza =  "string",
                         ValorDeclarado =  "string",
                     }
                 },
                 Response = new ResponseFacturacion
                 {
                     idTransaccion = id
                 }
             });
         }

         return NotFound(new ErrorMessageFacturacion
         {
             Detail = "Error",
             Errors = new List<ErrorFacturacion>
             {
                 new ErrorFacturacion
                 {
                     Field = "string",
                     Message = "No se ha encontrado la facturación"
                 }
             },
             Status = 404,
             Title = "string",
             Type = "Not Found"
         });
     }

     

}