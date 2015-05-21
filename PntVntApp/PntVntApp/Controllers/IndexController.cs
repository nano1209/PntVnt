using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PntVntApp.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            ViewBag.Title = "hola mundo -- app punto de venta";
            ViewBag.TituloFrm = "App punto de venta Inicio";
            return View();
        }

    }
}
