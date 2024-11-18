namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class guias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public guias()
        {
            guia_actividad = new HashSet<guia_actividad>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(15)]
        public string contacto { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int? experiencia { get; set; }

        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<guia_actividad> guia_actividad { get; set; }
    }
}
