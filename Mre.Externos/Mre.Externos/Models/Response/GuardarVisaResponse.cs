using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mre.Externos.Models.Response
{
  public class GuardarVisaResponse
  {
    public int IdTramiteVisa { get; set; }
    public string NumeroTramite { get; set; }
    public double Valor { get; set; }
    public string Codigo { get; set; }
    public string CodigoDescripcion { get; set; }
  }
}