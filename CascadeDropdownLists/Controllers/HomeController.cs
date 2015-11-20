using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDropdownLists.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCities(int id)
        {
            List<Models.City> cities = new List<Models.City>();

            if (id == 1)
            {
                cities.Add(new Models.City(1, "Lahore"));
                cities.Add(new Models.City(2, "Islamabad"));
            }
            else {
                cities.Add(new Models.City(1, "Paris"));
            }
            return this.Json(cities,JsonRequestBehavior.AllowGet);
        }
             
    }
}
