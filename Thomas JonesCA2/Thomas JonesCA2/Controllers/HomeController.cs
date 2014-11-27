// Thomas Jones - X00105989
using System.Web.Mvc;
using Thomas_JonesCA2.Models;

namespace Thomas_JonesCA2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Vehicle()
        {
            return View(new Vehicle() { VehicleType = Category.Car });
        }

        [HttpPost]
        public ActionResult Vehicle(Vehicle v)
        {
            return View(v);
        }
    }
}