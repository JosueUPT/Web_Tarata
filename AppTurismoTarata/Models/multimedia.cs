namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("multimedia")]
    public partial class multimedia
    {
        public int id { get; set; }

        public int? destino_id { get; set; }

        public int? actividad_id { get; set; }

        [Required]
        public string url { get; set; }

        public string descripcion { get; set; }

        [StringLength(20)]
        public string tipo { get; set; }

        public DateTime? fecha_subida { get; set; }

        public virtual actividades actividades { get; set; }

        public virtual destinos destinos { get; set; }
    }
}
