using andreani_sandbox.Models;
using andreani_sandbox.Models.Articulo;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace andreani_sandbox.Controllers;

[ApiController]
[Route("almacenes/productos")]
[SwaggerTag("Articulo")]
public class ArticuloController : ControllerBase
{
    /// <summary>
    /// Envio de solicitud de alta de productos
    /// </summary>
    /// <param name="articulo">Body para la solicitud de alta de producto</param>
    /// <response code="202">Accepted</response>
    /// <response code="400">Bad Request</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="503">Service Unavailable</response>
    [ProducesResponseType(typeof(ResponseArticulo), StatusCodes.Status202Accepted)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status503ServiceUnavailable)]
    [HttpPost]
    public IActionResult Post([FromBody] ArticuloRequest articulo)
    {
        string authorizationHeader = HttpContext.Request.Headers["Authorization"];

        if (authorizationHeader == "<API_KEY_VALUE>" || authorizationHeader == null)
        {
            return Unauthorized(new ErrorMessageArticulo
            {
                Detail = "Error",
                Errors = new List<ErrorArticulo>
                {
                    new ErrorArticulo
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
            return BadRequest(new ErrorMessageArticulo
            {
                Detail = "Error",
                Errors = new List<ErrorArticulo>
                {
                    new ErrorArticulo
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
    /// Metodo para consulta de solicitud
    /// </summary>
    /// <param name="idTransaccion">Id del articulo</param>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="404">Not Found</response>
    /// <response code="500">Internal Server Error</response>
    [ProducesResponseType(typeof(ArticuloResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorMessageArticulo), StatusCodes.Status500InternalServerError)]
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        string authorizationHeader = HttpContext.Request.Headers["Authorization"];

        if (authorizationHeader == "<API_KEY_VALUE>" || authorizationHeader == null)
        {
            return Unauthorized(new ErrorMessageArticulo
            {
                Detail = "Error",
                Errors = new List<ErrorArticulo>
                {
                    new ErrorArticulo
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
            return BadRequest(new ErrorMessageArticulo
            {
                Detail = "Error",
                Errors = new List<ErrorArticulo>
                {
                    new ErrorArticulo
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
            return Ok(new ArticuloResponse
            {
                estado = "string",
                fechaCreacion = "string",
                fechaModificacion = "string",
                razon = "string",
                request = new ArticuloRequest
                {
                    almacen = "string",
                    detalleDeArticulo = new DetalleDeArticulo
                    {
                        camposLibres = new List<CamposLibresArticulo>
                        {
                            new CamposLibresArticulo
                            {
                                contenido = "string",
                                meta = "string"
                            }
                        },
                        claseDeArticulo = "string",
                        codigo = "string",
                        codigoDeVidaUtil = "string",
                        coleccion = "string",
                        color = "string",
                        consumoEnDias = "string",
                        datosLogisticos = new DatosLogisticosArticulo
                        {
                            altoCaja = 0,
                            altoPallet = 0,
                            altura = 0,
                            alturaPack = 0,
                            alturaUnidad = 0,
                            anchoCaja = 0,
                            anchoPack = 0,
                            anchoPallet = 0,
                            anchoUnidad = 0,
                            anchura = 0,
                            cajasPorNivel = 0,
                            cantidadPorCaja = 0,
                            cantidadPorPallet = 0,
                            cantidadPorPaquete = 0,
                            largoCaja = 0,
                            largoPack = 0,
                            largoPallet = 0,
                            largoUnidad = 0,
                            longitud = 0,
                            nivelesPorPallet = 0,
                            pesoBruto = 0,
                            pesoCaja = 0,
                            pesoNeto = 0,
                            pesoPack = 0,
                            pesoPallet = 0,
                            pesoTara = 0,
                            volumen = 0,
                            volumenCubico = 0
                        },
                        descripcion = "string",
                        ean = "string",
                        esNumeroDeSerieDeEntradaUnico = "string",
                        esNumeroDeSerieSalidaUnico = "string",
                        estilo = "string",
                        finDeTemporada = "string",
                        grupos = new List<GruposArticulo>
                        {
                            new GruposArticulo
                            {
                                contenido = "string",
                                meta = "string"
                            }
                        },
                        indicadorDeVidaUtil = "string",
                        inicioDeTemporada = "string",
                        instruccionesDePreparacion = "string",
                        notas = "string",
                        otrosDatos = new List<OtrosDatosArticulo>
                        {
                            new OtrosDatosArticulo
                            {
                                contenido = "string",
                                meta = "string"
                            }
                        },
                        paisDeOrigen = "string",
                        pavu = "string",
                        propietario = "string",
                        psicotropico = "string",
                        rubro = "string",
                        serializado = "string",
                        talle = "string",
                        tema = "string",
                        temperatura = "string",
                        temporada = "string",
                        tipoEan = "string",
                        vencimientoEnDias = 0,
                        vidaUtilEntradaEnDias = "string",
                        vidaUtilSalidaEnDias = "string"
                    },
                    instancia = "string"
                },
                response = new ResponseArticulo
                {
                    idTransaccion = id
                }
            });
        }

        return NotFound(new ErrorMessageArticulo
        {
            Detail = "Error",
            Errors = new List<ErrorArticulo>
            {
                new ErrorArticulo
                {
                    Field = "string",
                    Message = "No se ha encontrado el articulo"
                }
            },
            Status = 404,
            Title = "string",
            Type = "Not Found"
        });
    }
}