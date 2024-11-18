using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppTurismoTarata.Models
{
    public partial class TarataApp : DbContext
    {
        public TarataApp()
            : base("name=TarataApp")
        {
        }

        public virtual DbSet<DetalleRuta> DetalleRuta { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleRuta>()
                .Property(e => e.costo)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Rutas>()
                .HasMany(e => e.DetalleRuta)
                .WithOptional(e => e.Rutas)
                .HasForeignKey(e => e.fkidRuta);
        }
    }
}
