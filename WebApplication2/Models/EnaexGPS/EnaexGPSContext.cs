using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models.EnaexGPS
{
    public partial class EnaexGPSContext : DbContext
    {
        public EnaexGPSContext()
        {
        }

        public EnaexGPSContext(DbContextOptions<EnaexGPSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EnaexCamionesGz> EnaexCamionesGz { get; set; }
        public virtual DbSet<EnaexEstados> EnaexEstados { get; set; }
        public virtual DbSet<EnaexEventosGpsfull> EnaexEventosGpsfull { get; set; }
        public virtual DbSet<EnaexSensores> EnaexSensores { get; set; }
        public virtual DbSet<EnaexUltimoEstado> EnaexUltimoEstado { get; set; }
        public virtual DbSet<EnaexUtilizacionGzfull> EnaexUtilizacionGzfull { get; set; }
        public virtual DbSet<EnaexUtilSitiosFull> EnaexUtilSitiosFull { get; set; }
        public virtual DbSet<EventosGps> EventosGps { get; set; }
        public virtual DbSet<EventosGpsfull> EventosGpsfull { get; set; }
        public virtual DbSet<Utilizacion> Utilizacion { get; set; }
        public virtual DbSet<UtilizacionFull> UtilizacionFull { get; set; }
        public virtual DbSet<UtilizacionGz> UtilizacionGz { get; set; }
        public virtual DbSet<UtilizacionGzfull> UtilizacionGzfull { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnaexCamionesGz>(entity =>
            {
                entity.HasKey(e => e.CodVehiculo);

                entity.ToTable("EnaexCamionesGZ");

                entity.Property(e => e.CodVehiculo)
                    .HasColumnName("codVehiculo")
                    .ValueGeneratedNever();

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnaexEstados>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora, e.Estado });

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnaexEventosGpsfull>(entity =>
            {
                entity.HasKey(e => e.NumActividad);

                entity.ToTable("EnaexEventosGPSFull");

                entity.HasIndex(e => new { e.CodVehiculo, e.FechaHora })
                    .HasName("indice_fechahora");

                entity.HasIndex(e => new { e.CodVehiculo, e.FechaHoraActividad })
                    .HasName("indice_fechahoraActividad");

                entity.Property(e => e.NumActividad)
                    .HasColumnName("numActividad")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodConductor).HasColumnName("codConductor");

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.CodTipoEvento).HasColumnName("codTipoEvento");

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.DesFlota)
                    .HasColumnName("desFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesVehiculo)
                    .HasColumnName("desVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistanciaIncremental).HasColumnName("distanciaIncremental");

                entity.Property(e => e.DistanciaViaje).HasColumnName("distanciaViaje");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHoraActividad).HasColumnName("fechaHoraActividad");

                entity.Property(e => e.FechaHoraActividadConFormato)
                    .IsRequired()
                    .HasColumnName("fechaHoraActividadConFormato")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraRecepcion).HasColumnName("fechaHoraRecepcion");

                entity.Property(e => e.Hdg).HasColumnName("hdg");

                entity.Property(e => e.Hdop).HasColumnName("hdop");

                entity.Property(e => e.IdAvl)
                    .HasColumnName("idAvl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ignicion).HasColumnName("ignicion");

                entity.Property(e => e.InsDt).HasColumnName("insDt");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.NomConductor)
                    .HasColumnName("nomConductor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomTipoEvento)
                    .HasColumnName("nomTipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumSatelites).HasColumnName("numSatelites");

                entity.Property(e => e.NumSim)
                    .HasColumnName("numSim")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odometro).HasColumnName("odometro");

                entity.Property(e => e.Puerto).HasColumnName("puerto");

                entity.Property(e => e.Rego)
                    .IsRequired()
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnName("velocidad");

                entity.Property(e => e.VelocidadMaxima).HasColumnName("velocidadMaxima");
            });

            modelBuilder.Entity<EnaexSensores>(entity =>
            {
                entity.HasKey(e => e.NumActividad);

                entity.Property(e => e.NumActividad)
                    .HasColumnName("numActividad")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodTipoEvento).HasColumnName("codTipoEvento");

                entity.Property(e => e.DatosExtendidos)
                    .HasColumnName("datosExtendidos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdDispositivo).HasColumnName("idDispositivo");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreConexion)
                    .HasColumnName("nombreConexion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDispositivo)
                    .HasColumnName("nombreDispositivo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Puerto).HasColumnName("puerto");

                entity.Property(e => e.Rego)
                    .IsRequired()
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnaexUltimoEstado>(entity =>
            {
                entity.HasKey(e => e.CodVehiculo);

                entity.Property(e => e.CodVehiculo)
                    .HasColumnName("codVehiculo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.CodTipoEvento).HasColumnName("codTipoEvento");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHoraActividadConFormato)
                    .IsRequired()
                    .HasColumnName("fechaHoraActividadConFormato")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ignicion).HasColumnName("ignicion");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomTipoEvento)
                    .HasColumnName("nomTipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumActividad).HasColumnName("numActividad");

                entity.Property(e => e.Odometro).HasColumnName("odometro");

                entity.Property(e => e.Rego)
                    .IsRequired()
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnName("velocidad");
            });

            modelBuilder.Entity<EnaexUtilizacionGzfull>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora, e.Geocerca });

                entity.ToTable("EnaexUtilizacionGZFull");

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Geocerca)
                    .HasColumnName("geocerca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnaexUtilSitiosFull>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora, e.Sitio });

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sitio)
                    .HasColumnName("sitio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventosGps>(entity =>
            {
                entity.HasKey(e => e.NumActividad);

                entity.ToTable("EventosGPS");

                entity.HasIndex(e => new { e.CodVehiculo, e.FechaHora })
                    .HasName("nci_wi_EventosGPS_6444D371814A2D6FF2E306FAA16C5EA2");

                entity.Property(e => e.NumActividad)
                    .HasColumnName("numActividad")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodConductor).HasColumnName("codConductor");

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.CodTipoEvento).HasColumnName("codTipoEvento");

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.DistanciaIncremental).HasColumnName("distanciaIncremental");

                entity.Property(e => e.DistanciaViaje).HasColumnName("distanciaViaje");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaHoraActividad).HasColumnName("fechaHoraActividad");

                entity.Property(e => e.FechaHoraRecepcion).HasColumnName("fechaHoraRecepcion");

                entity.Property(e => e.Hdg).HasColumnName("hdg");

                entity.Property(e => e.Hdop).HasColumnName("hdop");

                entity.Property(e => e.IdAvl)
                    .HasColumnName("idAvl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ignicion).HasColumnName("ignicion");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.NomConductor)
                    .HasColumnName("nomConductor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomTipoEvento)
                    .HasColumnName("nomTipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumSatelites).HasColumnName("numSatelites");

                entity.Property(e => e.Odometro).HasColumnName("odometro");

                entity.Property(e => e.Puerto).HasColumnName("puerto");

                entity.Property(e => e.Rego)
                    .IsRequired()
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnName("velocidad");

                entity.Property(e => e.VelocidadMaxima).HasColumnName("velocidadMaxima");
            });

            modelBuilder.Entity<EventosGpsfull>(entity =>
            {
                entity.HasKey(e => e.NumActividad);

                entity.ToTable("EventosGPSFull");

                entity.HasIndex(e => new { e.CodVehiculo, e.FechaHora })
                    .HasName("nci_wi_EventosGPSFull_6444D371814A2D6FF2E306FAA16C5EA2");

                entity.Property(e => e.NumActividad)
                    .HasColumnName("numActividad")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodConductor).HasColumnName("codConductor");

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.CodTipoEvento).HasColumnName("codTipoEvento");

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.DesFlota)
                    .HasColumnName("desFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesVehiculo)
                    .HasColumnName("desVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistanciaIncremental).HasColumnName("distanciaIncremental");

                entity.Property(e => e.DistanciaViaje).HasColumnName("distanciaViaje");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHoraActividad).HasColumnName("fechaHoraActividad");

                entity.Property(e => e.FechaHoraActividadConFormato)
                    .IsRequired()
                    .HasColumnName("fechaHoraActividadConFormato")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraRecepcion).HasColumnName("fechaHoraRecepcion");

                entity.Property(e => e.Hdg).HasColumnName("hdg");

                entity.Property(e => e.Hdop).HasColumnName("hdop");

                entity.Property(e => e.IdAvl)
                    .HasColumnName("idAvl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ignicion).HasColumnName("ignicion");

                entity.Property(e => e.InsDt).HasColumnName("insDt");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.NomConductor)
                    .HasColumnName("nomConductor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomTipoEvento)
                    .HasColumnName("nomTipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumSatelites).HasColumnName("numSatelites");

                entity.Property(e => e.NumSim)
                    .HasColumnName("numSim")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odometro).HasColumnName("odometro");

                entity.Property(e => e.Puerto).HasColumnName("puerto");

                entity.Property(e => e.Rego)
                    .IsRequired()
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipoEvento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Velocidad).HasColumnName("velocidad");

                entity.Property(e => e.VelocidadMaxima).HasColumnName("velocidadMaxima");
            });

            modelBuilder.Entity<Utilizacion>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora });

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.KmsRecorridos).HasColumnName("kmsRecorridos");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilizacionFull>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora });

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.KmsRecorridos).HasColumnName("kmsRecorridos");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilizacionGz>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora, e.Geocerca });

                entity.ToTable("UtilizacionGZ");

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Geocerca)
                    .HasColumnName("geocerca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilizacionGzfull>(entity =>
            {
                entity.HasKey(e => new { e.CodVehiculo, e.FechaHora, e.Geocerca });

                entity.ToTable("UtilizacionGZFull");

                entity.Property(e => e.CodVehiculo).HasColumnName("codVehiculo");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("fechaHora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Geocerca)
                    .HasColumnName("geocerca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodFlota).HasColumnName("codFlota");

                entity.Property(e => e.CodGrupoVehiculo).HasColumnName("codGrupoVehiculo");

                entity.Property(e => e.HorasUtilizacion).HasColumnName("horasUtilizacion");

                entity.Property(e => e.NomFlota)
                    .HasColumnName("nomFlota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomVehiculo)
                    .HasColumnName("nomVehiculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rego)
                    .HasColumnName("rego")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
