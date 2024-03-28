using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers
{
[Route("[controller]")]

    public class AdminController : Controller
    {

     

      [Route("Admin/dashboard")]
        public ActionResult dashboard()
        {
            return View("dashboard","_LayoutAdmin");
        }

        public ActionResult ManageProducts()
        {
            return View("ManageProducts","_LayoutAdmin");
        }

        public ActionResult ManageOrders()
        {
            return View("ManageOrders","_LayoutAdmin");
        }

        public ActionResult ManageUsers()
        {
            return View("ManageUsers","_LayoutAdmin");
        }

        public ActionResult Reports()
        {
            return View("Reports","_LayoutAdmin");
        }

    }
}

