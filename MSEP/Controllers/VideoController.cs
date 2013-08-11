using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSEP.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Assistir()
        {
            return View();
        }
    }
}
