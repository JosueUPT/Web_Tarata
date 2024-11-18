namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class actividades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public actividades()
        {
            guia_actividad = new HashSet<guia_actividad>();
            itinerario_actividad = new HashSet<itinerario_actividad>();
            multimedia = new HashSet<multimedia>();
            reseñas = new HashSet<reseñas>();
            reservas = new HashSet<reservas>();
        }

        public int id { get; set; }

        public int? destino_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime? fecha { get; set; }

        public TimeSpan? duracion { get; set; }

        [StringLength(50)]
        public string nivel_dificultad { get; set; }

        [StringLength(50)]
        public string idioma { get; set; }

        public decimal? precio { get; set; }

        public virtual destinos destinos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<guia_actividad> guia_actividad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itinerario_actividad> itinerario_actividad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<multimedia> multimedia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reseñas> reseñas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservas> reservas { get; set; }
    }
}
