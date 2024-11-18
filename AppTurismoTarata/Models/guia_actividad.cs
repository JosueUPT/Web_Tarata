namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class guia_actividad
    {
        public int id { get; set; }

        public int? guia_id { get; set; }

        public int? actividad_id { get; set; }

        public virtual actividades actividades { get; set; }

        public virtual guias guias { get; set; }
    }
}
