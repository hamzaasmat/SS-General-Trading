using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SS_General_Trading.Controllers
{
    public class PharmaceuticalController : Controller
    {
        // GET: Allopathic
        public ActionResult Allopathic()
        {
            return View();
        }

        // GET: HerbalMedicines
        public ActionResult HerbalMedicines()
        {
            return View();
        }
    }
}