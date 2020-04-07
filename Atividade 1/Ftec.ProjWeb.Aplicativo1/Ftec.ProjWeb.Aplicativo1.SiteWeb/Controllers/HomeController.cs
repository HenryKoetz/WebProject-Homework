using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjWeb.Aplicativo1.SiteWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() //Action
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}