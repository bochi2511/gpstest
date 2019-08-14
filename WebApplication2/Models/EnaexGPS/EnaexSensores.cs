using System;
using System.Collections.Generic;

namespace WebApplication2.Models.EnaexGPS
{
    public partial class EnaexSensores
    {
        public long NumActividad { get; set; }
        public string Rego { get; set; }
        public int? Puerto { get; set; }
        public int? CodTipoEvento { get; set; }
        public string Nombre { get; set; }
        public string NombreConexion { get; set; }
        public string NombreDispositivo { get; set; }
        public string DatosExtendidos { get; set; }
        public int? IdDispositivo { get; set; }
    }
}
