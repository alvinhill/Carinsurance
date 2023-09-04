using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carinsurance.Models;//**

namespace Carinsurance.Controllers
{
    public class HomeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();//**

        public ActionResult Index()
        {
            return View();
        }
             
    }
}