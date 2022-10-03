using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }   
        public ActionResult DavetiyeFormu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DavetiyeFormu(Davetiyemodel model)
        {

            return View();
        }
    }
}   