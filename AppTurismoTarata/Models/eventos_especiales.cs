namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class eventos_especiales
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        [StringLength(100)]
        public string ubicacion { get; set; }

        public DateTime? fecha { get; set; }

        public decimal? precio { get; set; }
    }
}
