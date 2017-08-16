using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SS_General_Trading.Controllers
{
    public class CropsController : Controller
    {
        // GET: Crops
        public ActionResult Rice()
        {
            return View();
        }

        // GET: Fruits
        public ActionResult Fruits()
        {
            return View();
        }

        // GET: FoodItems
        public ActionResult FoodItems()
        {
            return View();
        }

        // GET: FoodBeverage
        public ActionResult FoodBeverage()
        {
            return View();
        }
    }
}