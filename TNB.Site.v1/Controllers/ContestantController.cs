﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TNB.Site.v1.Controllers
{
    public class ContestantController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
    }
}