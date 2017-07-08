using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reportes.Areas.Reportes.Controllers
{
    public class MainController : Controller
    {
        // GET: Reportes/Main
        public ActionResult Index()
        { 
            return View();
        }
    }
}