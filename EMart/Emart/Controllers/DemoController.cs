﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emart.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult ShopCart()
        {
            return View();
        }

        public ActionResult Eshoppers()
        {
            return View();
        }
    }
}