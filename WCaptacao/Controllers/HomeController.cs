using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WCaptacao.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TelaAdmin()
        {
            return View();
        }
       public ActionResult TelaCoordenador()
        {
            return View();
        }
        public ActionResult TelaAgente()
        {
            return View();
        }
    }
}
