using System;
using System.Collections.Generic;

namespace WebApplication2.Models.EnaexGPS
{
    public partial class EnaexUltimoEstado
    {
        public long CodVehiculo { get; set; }
        public long NumActividad { get; set; }
        public string FechaHoraActividadConFormato { get; set; }
        public string Ubicacion { get; set; }
        public string NomFlota { get; set; }
        public long? CodGrupoVehiculo { get; set; }
        public int? CodFlota { get; set; }
        public string Rego { get; set; }
        public float? Odometro { get; set; }
        public bool? Ignicion { get; set; }
        public int? CodTipoEvento { get; set; }
        public string NomTipoEvento { get; set; }
        public string NomVehiculo { get; set; }
        public float? Velocidad { get; set; }
        public float? Latitud { get; set; }
        public float? Longitud { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Estado { get; set; }
    }
}
