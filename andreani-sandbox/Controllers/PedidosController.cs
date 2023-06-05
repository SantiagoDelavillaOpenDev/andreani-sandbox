using andreani_sandbox.Models.Pedidos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace andreani_sandbox.Controllers;

[ApiController]
[Route("almacenes/pedidos")]
[SwaggerTag("Pedidos")]
public class PedidosController : ControllerBase
{
    /// <summary>
    /// Generar una solicitud de alta de pedido
    /// </summary>
    /// <param name="pedido">Pedido</param>
    /// <response code="202">Accepted</response>
    /// <response code="400">Bad Request</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="500">Internal Server Error</response>
    /// <response code="503">Service Unavailable</response>
    [ProducesResponseType(typeof(ResponsePedidos), StatusCodes.Status202Accepted)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status503ServiceUnavailable)]

    [HttpPost]
    public IActionResult Post(PedidoRequest pedido)
    {
        string authorizationHeader = HttpContext.Request.Headers["Authorization"];

        if (authorizationHeader == "<API_KEY_VALUE>" || authorizationHeader == null)
        {
            return Unauthorized(new ErrorMessagePedidos
            {
                Detail = "Error",
                Errors = new List<ErrorPedidos>
                {
                    new ErrorPedidos
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
            return BadRequest(new ErrorMessagePedidos
            {
                Detail = "Error",
                Errors = new List<ErrorPedidos>
                {
                    new ErrorPedidos
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

        var respuesta = new ResponsePedidos
        {
            idTransaccion = numeroAleatorio
        };
        
        return StatusCode(202, respuesta);
    }
    
    /// <summary>
    /// Consulta una solicitud de alta pedido
    /// </summary>
    /// <param name="idTransaccion">Id del pedido</param>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="404">Not Found</response>
    /// <response code="500">Internal Server Error</response>
    [ProducesResponseType(typeof(PedidoResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorMessagePedidos), StatusCodes.Status500InternalServerError)]
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        string authorizationHeader = HttpContext.Request.Headers["Authorization"];

        if (authorizationHeader == "<API_KEY_VALUE>" || authorizationHeader == null)
        {
            return Unauthorized(new ErrorMessagePedidos
            {
                Detail = "Error",
                Errors = new List<ErrorPedidos>
                {
                    new ErrorPedidos
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
            return BadRequest(new ErrorMessagePedidos
            {
                Detail = "Error",
                Errors = new List<ErrorPedidos>
                {
                    new ErrorPedidos
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
            return Ok(new PedidoResponse
            {
                estado = "PENDIENTE",
                fechaCreacion = DateTime.Now,
                fechaModificacion = DateTime.Now,
                razon = "",
                request = new RequestPedidos
                {
                    almacen = "string",
                    contratoDistribucion = "string",
                    contratoWarehouse = "string",
                    instancia = "string",
                    pedido = new Pedido
                    {
                        almacenCliente = "string",
                        archivoRemito = new List<ArchivoRemito>
                        {
                            new ArchivoRemito
                            {
                                archivosRemito = "string"
                            }
                        },
                        cambioLoteDirigido = "string",
                        cot = "string",
                        datosAdicionales = new List<DatosAdicionalesPedidos>
                        {
                            new DatosAdicionalesPedidos
                            {
                                contenido = "string",
                                meta = "string"
                            }
                        },
                        destinatario = new Destinatario
                        {
                            contacto = "string",
                            direccion = new Direccion
                            {
                                calle = "string",
                                codigoPostal = "string",
                                departamento = "string",
                                localidad = "string",
                                numero = "string",
                                pais = "string",
                                piso = "string",
                                provincia = "string",
                                referenciaDeDomicilio = "string"
                            },
                            email = "string",
                            idDestinatario = "string",
                            idInternoCliente = "string",
                            nombreCompleto = "string",
                            numeroDeDocumento = "string",
                            telefono = "string",
                            tipoDeDocumento = "string"
                        },
                        distribuidor = new Distribuidor
                        {
                            datosAdicionales = new List<DatosAdicionalesPedidos>
                            {
                                new DatosAdicionalesPedidos
                                {
                                    contenido = "string",
                                    meta = "string"
                                }
                            },
                            etiqueta = "string",
                            nombre = "string",
                            numeroDeEnvio = "string",
                            remito = "string"
                        },
                        estatusOtDeTraza = "string",
                        facturaLegal = "string",
                        fechaDeExpedicionSolicitada = "string",
                        fechaDeFacturacion = "string",
                        fechaEntrega = "string",
                        fechaPedido = "string",
                        franjaHoraria = "string",
                        lineas = new List<Linea>
                        {
                            new Linea
                            {
                                admitePickingParcial = "string",
                                articulo = new Articulo
                                {
                                    cantidad = 0,
                                    codigo = "string",
                                    lote = new Lote
                                    {
                                        estado = "OK",
                                        fechaDeVencimiento = "string",
                                        loteDeFabricante = "string",
                                        loteSecundario = "string",
                                        otrosDatos = new List<DatosAdicionalesPedidos>
                                        {
                                            new DatosAdicionalesPedidos
                                            {
                                                contenido = "string",
                                                meta = "string",
                                            }
                                        }
                                    },
                                    numeroDePedido = "string",
                                    propietario = "string",
                                    unidadDeMedida = "string",
                                    zonaConsumo = "string"
                                },
                                contratoWarehouse = "string",
                                diasVencimientoMinimo = 0,
                                estatusOtDeAcondi = "string",
                                numeroDeLinea = "string",
                                tipoDeAcondicionamientoSecundario = "string",
                                tiposDeAcondicionamientoSecundario = new List<int>
                                {
                                    0
                                }
                            }
                        },
                        linkImpresionRemito = new List<LinkImpresionRemito>
                        {
                            new LinkImpresionRemito
                            {
                                impresionRemito = "string"
                            }
                        },
                        marketPlace = "string",
                        notas = "string",
                        numeroOrdenExterna = "string",
                        ordenCompra = "string",
                        precioValorFc = "string",
                        propietario = "string",
                        remito = "string",
                        tieneGestionCobranza = "string",
                        valorDeclarado = "string",
                    }
                },
                response = new ResponsePedidos
                {
                    idTransaccion = id
                }
            });
        };

        return NotFound(new ErrorMessagePedidos
        {
            Detail = "Error",
            Errors = new List<ErrorPedidos>
            {
                new ErrorPedidos
                {
                    Field = "string",
                    Message = "No se ha encontrado el pedido"
                }
            },
            Status = 404,
            Title = "string",
            Type = "Not Found"
        });
    }
}