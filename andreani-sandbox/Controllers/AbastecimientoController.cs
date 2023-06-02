using andreani_sandbox.Models.Abastecimiento;
using andreani_sandbox.Models.Pedidos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace andreani_sandbox.Controllers;

[ApiController]
[Route("/abastecimiento")]
[SwaggerTag("Abastecimiento")]
public class AbastecimientoController : ControllerBase
{
    /// <summary>
    /// Abastecimiento Solicitada
    /// </summary>
    /// <remarks>
    /// Servico generación del evento de Orden de Abastecimiento solicitada para el consumo de SCE
    /// </remarks>
    /// <param name="abastecimiento">Datos necesario para solicitar una Orden de Abastecimiento</param>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="500">Internal Server Error</response>
    [ProducesResponseType(typeof(ResponseAbastecimiento), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorMessageAbastecimiento), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageAbastecimiento), StatusCodes.Status500InternalServerError)]
    
    [HttpPost]
    public IActionResult Post(AbastecimientoRequest abastecimiento)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new ErrorMessageAbastecimiento
            {
                Detail = "Error",
                Errors = new List<ErrorAbastecimiento>
                {
                    new ErrorAbastecimiento
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

        var respuesta = new ResponseAbastecimiento
        {
            idTransaccion = numeroAleatorio
        };

        return Ok(respuesta);
    }


    /// <summary>
    /// Transacción de Abastecimiento
    /// </summary>
    /// <remarks>
    /// Servico de consulta del estado de la Orden de Compra Solicitada
    /// </remarks>
    /// <param name="id">Id Transacción</param>
    /// <response code="202">Accepted</response>
    /// <response code="400">Bad Request</response>
    /// <response code="404">Not Found</response>
    /// <response code="500">Internal Server Error</response>
    [ProducesResponseType(typeof(AbastecimientoResponse), StatusCodes.Status202Accepted)]
    [ProducesResponseType(typeof(ErrorMessageAbastecimiento), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageAbastecimiento), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorMessageAbastecimiento), StatusCodes.Status500InternalServerError)]
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new ErrorMessageAbastecimiento
            {
                Detail = "Error",
                Errors = new List<ErrorAbastecimiento>
                {
                    new ErrorAbastecimiento
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
            return Ok(new AbastecimientoResponse
                {
                    estado = "string",
                    fechaCreacion = "string",
                    fechaModificacion = "string",
                    razon = "string",
                    request = new RequestAbastecimiento
                    {
                        abastecimiento = new Abastecimiento
                        {
                            datosAdicionales = new List<DatosAdicionalesAbastecimiento>
                            {
                                new DatosAdicionalesAbastecimiento
                                {
                                    contenido = "string",
                                    meta = "string"
                                }
                            },
                            fechaDeRecepcionEsperada = "string",
                            fechaOrdenExterna = "string",
                            lineas = new List<LineaAbastecimiento>
                            {
                                new LineaAbastecimiento
                                {
                                    accionControlCalidad = new List<string>
                                    {
                                        "string"
                                    },
                                    almacenWMS = "string",
                                    articulo = new ArticuloAbastecimiento
                                    {
                                        codigo = "string",
                                        datosAdicionales = new List<DatosAdicionalesAbastecimiento>
                                        {
                                            new DatosAdicionalesAbastecimiento
                                            {
                                                contenido = "string",
                                                meta = "string"
                                            }
                                        },
                                        lote = new LoteAbastecimiento
                                        {
                                            datosAdicionales = new List<DatosAdicionalesAbastecimiento>
                                            {
                                                new DatosAdicionalesAbastecimiento
                                                {
                                                    contenido = "string",
                                                    meta = "string"
                                                }
                                            },
                                            estadoLote = "OK",
                                            fechaDeVencimiento = "string",
                                            loteDeFabricante = "string",
                                            loteSecundario = "string"
                                        }
                                    },
                                    avisoContraMuestra = "string",
                                    cantidadPedida = 0,
                                    codigoAnmat = "string",
                                    contratoWarehouse = "string",
                                    datosAdicionales = new List<DatosAdicionalesAbastecimiento>
                                    {
                                        new DatosAdicionalesAbastecimiento
                                        {
                                            contenido = "string",
                                            meta = "string"
                                        }
                                    },
                                    estatusOTdeTrazaporLPN = "string",
                                    estatusOtDeAcondporLpn = "string",
                                    numeroDeLinea = "string",
                                    productoTrazable = "string",
                                    propietario = "string",
                                    tipoAcondicionamiento = new List<string>
                                    {
                                        "string"
                                    },
                                    tipoControlCalidad = new List<string>
                                    {
                                        "string"
                                    },
                                    tipoTraza = "string",
                                    ubicacionPredeterminada = "string",
                                    unidadMedida = "string",
                                    valorDeclarado = "string",
                                    vidaUtildelLote = "string"
                                }
                            },
                            numeroOrdenExterna = "string",
                            origen = new Origen
                            {
                                calle = "string",
                                codigoPostal = "string",
                                datosAdicionales = new List<DatosAdicionalesAbastecimiento>
                                {
                                    new DatosAdicionalesAbastecimiento
                                    {
                                        contenido = "string",
                                        meta = "string"
                                    }
                                },
                                departamento = "string",
                                id = "string",
                                localidad = "string",
                                nombreProvincia = "string",
                                numero = "string",
                                piso = "string"
                            },
                            propietario = "string",
                            transportista = new Transportista
                            {
                                datosPersonales = new DatosPersonales
                                {
                                    email = "string",
                                    nombreCompleto = "string",
                                    numeroDeDocumento = "string",
                                    tipoDeDocumento = "string"
                                },
                                idTransportista = "string"
                            }
                        },
                        almacen = "string",
                        contratoDistribucion = "string",
                        contratoWarehouse = "string",
                        instancia = "string"
                    },
                    response = new ResponseAbastecimiento
                    {
                        idTransaccion = 0
                    }
                }
            );
        }

        return NotFound(new ErrorMessageAbastecimiento
        {
            Detail = "Error",
            Errors = new List<ErrorAbastecimiento>
            {
                new ErrorAbastecimiento
                {
                    Field = "string",
                    Message = "No se ha encontrado el orden de compra"
                }
            },
            Status = 404,
            Title = "string",
            Type = "Not Found"
        });
    }
}