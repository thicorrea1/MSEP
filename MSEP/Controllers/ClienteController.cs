﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSEP.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult CadastroOk()
        {
            return View();
        }

    }
}
