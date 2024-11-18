using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppTurismoTarata.Models
{
    public partial class TarataModel : DbContext
    {
        public TarataModel()
            : base("name=TarataModel")
        {
        }

        public virtual DbSet<actividades> actividades { get; set; }
        public virtual DbSet<destinos> destinos { get; set; }
        public virtual DbSet<eventos_especiales> eventos_especiales { get; set; }
        public virtual DbSet<guia_actividad> guia_actividad { get; set; }
        public virtual DbSet<guias> guias { get; set; }
        public virtual DbSet<itinerario_actividad> itinerario_actividad { get; set; }
        public virtual DbSet<itinerarios> itinerarios { get; set; }
        public virtual DbSet<multimedia> multimedia { get; set; }
        public virtual DbSet<reseñas> reseñas { get; set; }
        public virtual DbSet<reservas> reservas { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actividades>()
                .Property(e => e.precio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<actividades>()
                .HasMany(e => e.guia_actividad)
                .WithOptional(e => e.actividades)
                .HasForeignKey(e => e.actividad_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<actividades>()
                .HasMany(e => e.itinerario_actividad)
                .WithOptional(e => e.actividades)
                .HasForeignKey(e => e.actividad_id);

            modelBuilder.Entity<actividades>()
                .HasMany(e => e.multimedia)
                .WithOptional(e => e.actividades)
                .HasForeignKey(e => e.actividad_id);

            modelBuilder.Entity<actividades>()
                .HasMany(e => e.reseñas)
                .WithOptional(e => e.actividades)
                .HasForeignKey(e => e.actividad_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<actividades>()
                .HasMany(e => e.reservas)
                .WithOptional(e => e.actividades)
                .HasForeignKey(e => e.actividad_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<destinos>()
                .HasMany(e => e.actividades)
                .WithOptional(e => e.destinos)
                .HasForeignKey(e => e.destino_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<destinos>()
                .HasMany(e => e.multimedia)
                .WithOptional(e => e.destinos)
                .HasForeignKey(e => e.destino_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<eventos_especiales>()
                .Property(e => e.precio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<guias>()
                .HasMany(e => e.guia_actividad)
                .WithOptional(e => e.guias)
                .HasForeignKey(e => e.guia_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<itinerarios>()
                .HasMany(e => e.itinerario_actividad)
                .WithOptional(e => e.itinerarios)
                .HasForeignKey(e => e.itinerario_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<usuarios>()
                .HasMany(e => e.itinerarios)
                .WithOptional(e => e.usuarios)
                .HasForeignKey(e => e.usuario_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<usuarios>()
                .HasMany(e => e.reseñas)
                .WithOptional(e => e.usuarios)
                .HasForeignKey(e => e.usuario_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<usuarios>()
                .HasMany(e => e.reservas)
                .WithOptional(e => e.usuarios)
                .HasForeignKey(e => e.usuario_id)
                .WillCascadeOnDelete();
        }
    }
}
