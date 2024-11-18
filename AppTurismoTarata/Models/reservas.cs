namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class reservas
    {
        public int id { get; set; }

        public int? usuario_id { get; set; }

        public int? actividad_id { get; set; }

        public DateTime? fecha_reserva { get; set; }

        public int cantidad { get; set; }

        public virtual actividades actividades { get; set; }

        public virtual usuarios usuarios { get; set; }
    }
}
