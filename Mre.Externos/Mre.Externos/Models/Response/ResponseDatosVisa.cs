using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mre.Externos.Models.Response
{
  public class ResponseDatosVisa
  {
    public string Codigo { get; set; }
    public string Detalle { get; set; }

    public List<DatosVisaInfo> LisDatosVisa { get; set; }

    public ResponseDatosVisa()
    {
      LisDatosVisa = new List<DatosVisaInfo>();
    }

  public class DatosVisaInfo
    {
      public string EstadoVisa { get; set; }
      public int? IdPersona { get; set; }
      public string FechaCaducidad { get; set; }
      public string FechaConcesion { get; set; }
      public int? IdActoConsularVisa { get; set; }
      public int? IdCentroAdministrativo { get; set; }
      public int? IdTramite { get; set; }
      public string NombreActoConsularVisa { get; set; }
      public string NombreCentroAdministrativo { get; set; }
      public string Nombres { get; set; }
      public string NumeroPasaporte { get; set; }
      public string NumeroVisa { get; set; }
      public string PrimerApellido { get; set; }
      public string SegundoApellido { get; set; }
    }
  }
}