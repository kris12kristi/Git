using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laba8.Models;


namespace Laba8.Controllers
{
    public class HomeController : Controller
    {
     LabContext db = new LabContext();   
        public ActionResult Index()
        {

            return View();
        }
        
    }
}