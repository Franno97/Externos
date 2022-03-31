using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mre.Externos.Models.Request
{
  public class RequestOficioCancelacion : Seguridad
  {
    public int IdActoConsularCancelacion { get; set; }
    
    public int IdActoConsularVisa {get;set;}

    
    public int IdCentroAdministrativo {get;set;}

    
    public int IdCentroAdministrativoCancelacion {get;set;}

    
    public int IdFuncionario {get;set;}

    
    public int IdFuncionarioNuevoSistema {get;set;}

    
    public int IdPersona {get;set;}

    
    public int IdSignatario {get;set;}

    
    public int IdTramite {get;set;}

    
    public int IdTramiteNuevoSistema {get;set;}

    
    public string NumeroPasaporte {get;set;}

    
    public string NumeroVisa {get;set;}

    
    public string ObservacionesCancelacion {get;set;}
  }
}