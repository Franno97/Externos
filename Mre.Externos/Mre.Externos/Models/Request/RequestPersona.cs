using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mre.Externos.Models.Request
{
  public class RequestPersona : Seguridad
  {
    public string nombres { get; set; }
    public string primerApellido { get; set; }
    public string segundoApellido { get; set; }
    public int idNacionalidad { get; set; }
    public DateTime fechaNacimiento { get; set; }

  }
}