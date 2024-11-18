namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;


    [Table("DetalleRuta")]
    public partial class DetalleRuta
    {
        [Key]
        public int idDetalleRuta { get; set; }

        public int? fkidRuta { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public decimal? costo { get; set; }

        [StringLength(100)]
        public string Horario { get; set; }

        public virtual Rutas Rutas { get; set; }

        // Metodos

        public List<DetalleRuta> ListarDetalleRuta()
        {
            var query = new List<DetalleRuta>();
            try
            {
                using (var db = new TarataApp())
                {
                    query = db.DetalleRuta.ToList();
                }
            }
            catch (Exception) { throw; }
            return query;
        }

        public List<DetalleRuta> ListarDetalleRutaPorId(int idRuta)
        {
            var query = new List<DetalleRuta>();
            try
            {
                using (var db = new TarataApp())
                {
                    query = db.DetalleRuta
                              .Where(d => d.fkidRuta == idRuta)
                              .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return query;
        }
    }
}
