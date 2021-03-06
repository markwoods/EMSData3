﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMSData.Controllers
{
    public class DevStartController : Controller
    {
        // GET: DevStart
        public ActionResult Index()
        {
            return View();
        }

        // GET: DevStart/Welcome

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = ID;

            return View();
            
            //return "This is the Welcome action method...";
 //               return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + ID);
        }
    
    }

}