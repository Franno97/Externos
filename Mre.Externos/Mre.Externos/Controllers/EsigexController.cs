using System.Web.Http;
using Mre.Externos.ServiceReferenceEsigex;
using System.Web.Http.Cors;
using System.Configuration;

namespace Mre.Externos.Controllers
{
  [RoutePrefix("api/esigex")]
  public class EsigexController : ApiController
  {
    public string usuario { get; set; }
    public string contrasenia { get; set; }

    public EsigexController()
    {
      var connect = ConfigurationManager.AppSettings;
      usuario = connect["usuario"];
      contrasenia = connect["contrasenia"];
    }


    [Route("BuscarVisaPorDatosPersona")]
    [HttpPost]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public Models.Response.ResponseDatosVisa BuscarVisaPorDatosPersona(Models.Request.RequestPersona request)
    {
      Models.Response.ResponseDatosVisa datosVisa = new Models.Response.ResponseDatosVisa();
      ServiceReferenceEsigex.ServiceEsigexClient ws = new ServiceEsigexClient();
      var result = ws.BuscarVisaPorDatosPersona(request.nombres, request.primerApellido, request.segundoApellido, request.idNacionalidad, request.fechaNacimiento, usuario, contrasenia);
      datosVisa.Codigo = result.Codigo;
      datosVisa.Detalle = result.Detalle;
      foreach (var item in result.ListDatosVisa)
      {
        datosVisa.LisDatosVisa.Add(new Models.Response.ResponseDatosVisa.DatosVisaInfo
        {
          EstadoVisa = item.EstadoVisa,
          IdPersona = item.IdPersona,
          FechaCaducidad = item.FechaCaducidad,
          FechaConcesion = item.FechaConcesion,
          IdActoConsularVisa = item.IdActoConsularVisa,
          IdCentroAdministrativo = item.IdCentroAdministrativo,
          IdTramite = item.IdTramite,
          NombreActoConsularVisa = item.NombreActoConsularVisa,
          NombreCentroAdministrativo = item.NombreCentroAdministrativo,
          Nombres = item.Nombres,
          NumeroPasaporte = item.NumeroPasaporte,
          NumeroVisa = item.NumeroVisa,
          PrimerApellido = item.PrimerApellido,
          SegundoApellido = item.SegundoApellido
        });
      }
      return datosVisa;
    }


    [Route("BuscarVisaPorNumero")]
    [HttpPost]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public Models.Response.ResponseDatosVisa BuscarVisaPorNumero(Models.Request.RequestVisa request)
    {
      Models.Response.ResponseDatosVisa datosVisa = new Models.Response.ResponseDatosVisa();
      ServiceReferenceEsigex.ServiceEsigexClient ws = new ServiceEsigexClient();
      var result = ws.BuscarVisaPorNumero(request.numeroVisa, usuario, contrasenia);
      datosVisa.Codigo = result.Codigo;
      datosVisa.Detalle = result.Detalle;
      foreach (var item in result.ListDatosVisa)
      {
        datosVisa.LisDatosVisa.Add(new Models.Response.ResponseDatosVisa.DatosVisaInfo
        {
          EstadoVisa = item.EstadoVisa,
          IdPersona = item.IdPersona,
          FechaCaducidad = item.FechaCaducidad,
          FechaConcesion = item.FechaConcesion,
          IdActoConsularVisa = item.IdActoConsularVisa,
          IdCentroAdministrativo = item.IdCentroAdministrativo,
          IdTramite = item.IdTramite,
          NombreActoConsularVisa = item.NombreActoConsularVisa,
          NombreCentroAdministrativo = item.NombreCentroAdministrativo,
          Nombres = item.Nombres,
          NumeroPasaporte = item.NumeroPasaporte,
          NumeroVisa = item.NumeroVisa,
          PrimerApellido = item.PrimerApellido,
          SegundoApellido = item.SegundoApellido
        });
      }
      return datosVisa;
    }

    [Route("GuardarCancelacionPorOficioVisas")]
    [HttpPost]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public void GuardarCancelacionPorOficioVisas(Models.Request.RequestOficioCancelacion request)
    {
      Models.Response.ResponseDatosVisa datosVisa = new Models.Response.ResponseDatosVisa();
      ServiceReferenceEsigex.ServiceEsigexClient ws = new ServiceEsigexClient();
      var result = ws.GuardarCancelacionPorOficioVisas(new CancelacionVisasMessage
      {
        IdActoConsularCancelacion = request.IdActoConsularCancelacion,
        IdActoConsularVisa = request.IdActoConsularCancelacion,
        IdCentroAdministrativo = request.IdActoConsularCancelacion,
        IdCentroAdministrativoCancelacion = request.IdActoConsularCancelacion,
        IdFuncionario = request.IdFuncionario,
        IdFuncionarioNuevoSistema = request.IdFuncionarioNuevoSistema,
        IdPersona = request.IdPersona,
        IdSignatario = request.IdSignatario,
        IdTramite = request.IdTramite,
        IdTramiteNuevoSistema = request.IdTramiteNuevoSistema,
        ObservacionesCancelacion = request.ObservacionesCancelacion,
        NumeroPasaporte = request.NumeroPasaporte,
        NumeroVisa = request.NumeroVisa,
        usuario = usuario,
        contrasenia = contrasenia
      });
    }
  }
}
