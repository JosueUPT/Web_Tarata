using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppTurismoTarata.Models;
namespace AppTurismoTarata.Controllers
{
    public class RutasController : Controller
    {
        List<DetalleRuta> lugares = new List<DetalleRuta>();
        // GET: Rutas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccesoTarata()
        {
            lugares.Add(new DetalleRuta
            {
                idDetalle = 1,
                idRuta = 1,
                nombre = "Plaza Coronel Gregorio Albarracin",
                descripcion = "Esta plaza...",
                costo = 10,
                horario = "09:00 - 17:00"
            });
            lugares.Add(new DetalleRuta
            {
                idDetalle = 2,
                idRuta = 1,
                nombre = "Mercado",
                descripcion = "Mercado...",
                costo = 10,
                horario = "09:00 - 17:00"
            });
            lugares.Add(new DetalleRuta
            {
                idDetalle = 3,
                idRuta = 1,
                nombre = "Templo San Benedicto",
                descripcion = "Templo...",
                costo = 10,
                horario = "09:00 - 17:00"
            });
            lugares.Add(new DetalleRuta
            {
                idDetalle = 4,
                idRuta = 1,
                nombre = "Municipalidad Provincial de Tarata",
                descripcion = "La municipalidad...",
                costo = 10,
                horario = "09:00 - 17:00"
            });
            return View(lugares);
        }
    }
}