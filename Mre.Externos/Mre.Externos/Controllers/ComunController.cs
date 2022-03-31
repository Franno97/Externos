using Mre.Externos.ServiceReferenceComun;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Mre.Externos.Controllers
{
  [RoutePrefix("api/comun")]
  public class ComunController : ApiController
  {
    [Route("ObtenerActividadesPorTipoVisa")]
    [HttpGet]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public List<ObtenerActividadesPorTipoVisa_Result> ObtenerActividadesPorTipoVisa(int idActoConsularVisa)
    {
      var datosVisa = new List<ObtenerActividadesPorTipoVisa_Result>();
      var ws = new ServiceComunClient();
      var result = ws.ObtenerActividadesPorTipoVisa(idActoConsularVisa);
      foreach (var i in result)
      {
        datosVisa.Add(new ObtenerActividadesPorTipoVisa_Result { idField = i.idField, nombreField = i.nombreField });
      }
      return datosVisa;
    }

    [Route("TraerListaEntidadesAuspiciantesPorVisa")]
    [HttpGet]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public List<EntidadAuspicianteCentroAdministrativo> TraerListaEntidadesAuspiciantesPorVisa(int idActoConsularVisa)
    {
      var datosVisa = new List<EntidadAuspicianteCentroAdministrativo>();
      var ws = new ServiceComunClient();
      var result = ws.TraerListaEntidadesAuspiciantesPorVisa(idActoConsularVisa);
      foreach (var i in result)
      {
        datosVisa.Add(new EntidadAuspicianteCentroAdministrativo { IdEntidadAuspiciante = i.IdEntidadAuspiciante, Nombre = i.Nombre });
      }
      return datosVisa;
    }

    [Route("TraerRequisitosVisasPorActoConsular")]
    [HttpGet]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "")]
    public List<Requisito> TraerRequisitosVisasPorActoConsular(int idActoConsularVisa)
    {
      var datosVisa = new List<Requisito>();
      var ws = new ServiceComunClient();
      var result = ws.TraerRequisitosVisasPorActoConsular(idActoConsularVisa);
      foreach (var i in result)
      {
        datosVisa.Add(new Requisito
        {
          IdActoConsular = i.IdActoConsular,
          Descripcion = i.Descripcion,
          EntidadActiva = i.EntidadActiva,
          Nombre = i.Nombre,
          IdRequisito = i.IdRequisito,
          VersionFila = i.VersionFila,
          EntityState = i.EntityState,
          ExtensionData = i.ExtensionData
        });
      }
      return datosVisa;
    }
  }
}
