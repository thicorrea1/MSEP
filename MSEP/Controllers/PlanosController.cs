using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSEP.Controllers
{
    public class PlanosController : Controller
    {
        //
        // GET: /Planos/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Upgrade()
        {
            return View();
        }
    }
}
