using System;
using System.Collections.Generic;

namespace WebApplication2.Models.EnaexGPS
{
    public partial class EventosGps
    {
        public long NumActividad { get; set; }
        public long FechaHoraActividad { get; set; }
        public string Ubicacion { get; set; }
        public int? CodConductor { get; set; }
        public string NomFlota { get; set; }
        public string IdAvl { get; set; }
        public long? CodGrupoVehiculo { get; set; }
        public long? CodVehiculo { get; set; }
        public int? Puerto { get; set; }
        public int? VelocidadMaxima { get; set; }
        public long? DistanciaViaje { get; set; }
        public long? DistanciaIncremental { get; set; }
        public int? CodFlota { get; set; }
        public int? Hdg { get; set; }
        public float? Hdop { get; set; }
        public long? FechaHoraRecepcion { get; set; }
        public string Rego { get; set; }
        public int? NumSatelites { get; set; }
        public long? Odometro { get; set; }
        public string TipoEvento { get; set; }
        public bool? Ignicion { get; set; }
        public int? CodTipoEvento { get; set; }
        public string NomTipoEvento { get; set; }
        public string NomVehiculo { get; set; }
        public string NomConductor { get; set; }
        public long? Velocidad { get; set; }
        public float? Latitud { get; set; }
        public float? Longitud { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
