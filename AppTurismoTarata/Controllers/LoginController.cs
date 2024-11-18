using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppTurismoTarata.Models;
using AppTurismoTarata.Filters;

namespace AppTurismoTarata.Controllers
{
    public class LoginController : Controller
    {
        private Usuario usuario = new Usuario();

        // GET: Login
        //[NoLogin]
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Acceder(string Usuario, string Password)
        {
            var rm = usuario.Acceder(Usuario, Password);

            if (rm.response)
            {
                rm.href = Url.Content("~/Default");
            }
            return Json(rm);
        }

        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
            return Redirect("~/Login");
        }
    }
}