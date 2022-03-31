using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mre.Externos.Models.Request
{
  public class GuardarVisaRequest
  {
    public byte[] DocumentoPdf { get; set; }
    public int Exoneracion { get; set; }
    public DateTime FechaAutorizacion { get; set; }
    public DateTime FechaFactura { get; set; }
    public DateTime FechaPago { get; set; }
    public DateTime FechaVigenciaVisa { get; set; }
    public int IdFormaPago { get; set; }
    public int IdFuncionarioCajero { get; set; }
    public int IdFuncionarioEsigexAutorizacion { get; set; }
    public int IdFuncionarioEsigexVisa { get; set; }
    public Guid IdFuncionarioNuevoSistema { get; set; }
    public Guid IdTramiteNuevoSistema { get; set; }
    public int IdTramiteSolicitud { get; set; }
    public string NumeroComprobante { get; set; }
    public int NumeroEntradasPermitidas { get; set; }
    public string NumeroFactura { get; set; }
    public string NumeroVisaNuevoSistema { get; set; }
    public string ObservacionAutorizacion { get; set; }
    public bool VisaAutorizada { get; set; }
  }
}