using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTurismoTarata.Models
{
    public class DetalleRuta
    {
        public int idDetalle { get; set; }
        public int idRuta { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public string horario { get; set; }

        //Metodos


    }
}