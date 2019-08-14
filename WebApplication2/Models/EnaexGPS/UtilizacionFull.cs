using System;
using System.Collections.Generic;

namespace WebApplication2.Models.EnaexGPS
{
    public partial class UtilizacionFull
    {
        public long CodVehiculo { get; set; }
        public DateTime FechaHora { get; set; }
        public double? HorasUtilizacion { get; set; }
        public string Rego { get; set; }
        public string NomVehiculo { get; set; }
        public int? CodFlota { get; set; }
        public string NomFlota { get; set; }
        public long? CodGrupoVehiculo { get; set; }
        public double? KmsRecorridos { get; set; }
    }
}
