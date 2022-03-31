using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;
using Mre.Externos.Models.Request;
using Mre.Externos.ServiceReferenceAsuntosMigratorios;
using Mre.Externos.ServiceReferenceComun;

namespace Mre.Externos.Controllers
{
  [RoutePrefix("api/asuntosMigratorios")]
  public class AsuntosMigratoriosController : ApiController
  {
    public string usuario { get; set; }
    public string contrasenia { get; set; }
    public AsuntosMigratoriosController()
    {
      var connect = ConfigurationManager.AppSettings;
      usuario = connect["usuario"];
      contrasenia = connect["contrasenia"];
    }
    /// <summary>
    /// BuscarVisaPorDatosPersona
    /// </summary>
    /// <returns></returns>
    [Route("GuardarSolicitudVisa")]
    [HttpPost]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public GeneracionSolicitudMessage GuardarSolicitudVisa(SolicitudInfoRequest solicitudInfoRequest)
    {
      var requestDetalle = new RequisitosSolicitudMessage[solicitudInfoRequest.RequisitosVisa.Count];
      for (int i = 0; i < solicitudInfoRequest.RequisitosVisa.Count - 1; i++)
      {
        requestDetalle[i].IdRequisito = solicitudInfoRequest.RequisitosVisa[i].IdRequisito;
        requestDetalle[i].IdActoConsularVisa = solicitudInfoRequest.RequisitosVisa[i].IdRequisito;
        requestDetalle[i].IdRequisito = solicitudInfoRequest.RequisitosVisa[i].IdRequisito;
        requestDetalle[i].IdRequisito = solicitudInfoRequest.RequisitosVisa[i].IdRequisito;
      }
      var solicitudInfo = new SolicitudInfo
      {
        UsuarioWs = usuario,
        ContraseniaWs = contrasenia,
        CorreoElectronico = solicitudInfoRequest.CorreoElectronico,
        DireccionResidencia = solicitudInfoRequest.DireccionResidencia,
        Exoneracion = solicitudInfoRequest.Exoneracion,
        FechaNacimiento = solicitudInfoRequest.FechaNacimiento,
        FechaFactura = solicitudInfoRequest.FechaFactura,
        FechaCaducidadDocumento = solicitudInfoRequest.FechaCaducidadDocumento,
        FechaEmisionDocumento = solicitudInfoRequest.FechaEmisionDocumento,
        FechaPago = solicitudInfoRequest.FechaPago,
        FechaRegistroSolicitud = solicitudInfoRequest.FechaRegistroSolicitud,
        Foto = solicitudInfoRequest.Foto,
        IdActividadVisa = solicitudInfoRequest.IdActividadVisa,
        IdActoConsularSolicitudVisa = 1,
        IdActoConsularVisa = solicitudInfoRequest.IdActoConsularVisa,
        IdCalidadMigratoria = solicitudInfoRequest.IdCalidadMigratoria,
        IdCentroAdministrativo = solicitudInfoRequest.IdCentroAdministrativo,
        IdCiudadNacimiento = solicitudInfoRequest.IdCiudadNacimiento,
        IdCiudadResidencia = solicitudInfoRequest.IdCiudadResidencia,
        IdEntidadAuspiciante = solicitudInfoRequest.IdEntidadAuspiciante,
        IdFormaPago = solicitudInfoRequest.IdFormaPago,
        IdFuncionarioCajero = solicitudInfoRequest.IdFuncionarioCajero,
        IdGrupoVisa = solicitudInfoRequest.IdGrupoVisa,
        IdNacionalidad = solicitudInfoRequest.IdNacionalidad,
        IdTipoDocumento = solicitudInfoRequest.IdTipoDocumento,
        IdFuncionarioCreacionEsigex = solicitudInfoRequest.IdFuncionarioCreacionEsigex,
        IdFuncionarioNuevoSistema = solicitudInfoRequest.IdFuncionarioNuevoSistema,
        IdTramiteNuevoSistema = solicitudInfoRequest.IdTramiteNuevoSistema,
        NombresExtranjero = solicitudInfoRequest.NombresExtranjero,
        LugarEmisionDocumento = solicitudInfoRequest.LugarEmisionDocumento,
        NumeroComprobante = solicitudInfoRequest.NumeroComprobante,
        NumeroDocumento = solicitudInfoRequest.NumeroDocumento,
        NumeroFactura = solicitudInfoRequest.NumeroFactura,
        NumeroVisaNuevoSistema = solicitudInfoRequest.NumeroVisaNuevoSistema,
        ObservacionSolicitud = solicitudInfoRequest.ObservacionSolicitud,
        PrimerApellidoExtranjero = solicitudInfoRequest.PrimerApellidoExtranjero,
        SegundoApellidoExtranjero = solicitudInfoRequest.SegundoApellidoExtranjero,
        Telefono = solicitudInfoRequest.Telefono,
        RequisitosVisa = requestDetalle
      };

      var datosVisa = new GeneracionSolicitudMessage();
      var ws = new ServiceAsuntosMigratoriosClient();
      var result = ws.GuardarSolicitudVisa(solicitudInfo);
      datosVisa = result;
      return datosVisa;
    }
    [Route("GuardarVisa")]
    [HttpPost]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public GeneracionVisaMessage GuardarVisa(GuardarVisaRequest guardarVisaRequest)
    {
      var datosVisa = new GeneracionVisaMessage();
      var datos = new VisaInfo
      {
        UsuarioWs = usuario,
        ContraseniaWs = contrasenia,
        DocumentoPdf = guardarVisaRequest.DocumentoPdf,
        Exoneracion = guardarVisaRequest.Exoneracion,
        FechaFactura = guardarVisaRequest.FechaFactura,
        FechaPago = guardarVisaRequest.FechaPago,
        IdFormaPago = guardarVisaRequest.IdFormaPago,
        FechaVigenciaVisa = guardarVisaRequest.FechaVigenciaVisa,
        IdFuncionarioCajero = guardarVisaRequest.IdFuncionarioCajero,
        IdTramiteNuevoSistema = guardarVisaRequest.IdTramiteNuevoSistema,
        IdTramiteSolicitud = guardarVisaRequest.IdTramiteSolicitud,
        NumeroComprobante = guardarVisaRequest.NumeroComprobante,
        NumeroFactura = guardarVisaRequest.NumeroFactura,
        ObservacionAutorizacion = guardarVisaRequest.ObservacionAutorizacion,
        VisaAutorizada = guardarVisaRequest.VisaAutorizada,
        NumeroEntradasPermitidas = guardarVisaRequest.NumeroEntradasPermitidas,
        IdFuncionarioEsigexVisa = guardarVisaRequest.IdFuncionarioEsigexVisa,
        FechaAutorizacion = guardarVisaRequest.FechaAutorizacion,
        IdFuncionarioEsigexAutorizacion = guardarVisaRequest.IdFuncionarioEsigexAutorizacion,
        IdFuncionarioNuevoSistema = guardarVisaRequest.IdFuncionarioNuevoSistema,
        NumeroVisaNuevoSistema = guardarVisaRequest.NumeroVisaNuevoSistema
      };
      var ws = new ServiceAsuntosMigratoriosClient();
      var result = ws.GuardarVisa(datos);
      datosVisa = result;
      return datosVisa;
    }

  }
}
