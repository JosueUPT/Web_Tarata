namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class itinerarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public itinerarios()
        {
            itinerario_actividad = new HashSet<itinerario_actividad>();
        }

        public int id { get; set; }

        public int? usuario_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime? fecha_creacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itinerario_actividad> itinerario_actividad { get; set; }

        public virtual usuarios usuarios { get; set; }
    }
}
