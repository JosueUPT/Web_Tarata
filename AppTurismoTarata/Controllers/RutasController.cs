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


        private DetalleRuta objLugar = new DetalleRuta();

        // GET: Rutas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccesoTarata()
        {
            // AccesoTarata corresponde a IdRuta = 1
            return View(objLugar.ListarDetalleRutaPorId(1));
        }

        public ActionResult Senderismo()
        {
            // Senderismo corresponde a IdRuta = 2
            return View(objLugar.ListarDetalleRutaPorId(2));
        }

        public ActionResult Relax()
        {
            // Relax corresponde a IdRuta = 3
            return View(objLugar.ListarDetalleRutaPorId(3));
        }

        public ActionResult DeportesExtremos()
        {
            // DeportesExtremos corresponde a IdRuta = 4
            return View(objLugar.ListarDetalleRutaPorId(4));
        }

    }
}