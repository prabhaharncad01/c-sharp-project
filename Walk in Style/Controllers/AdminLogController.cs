using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers;

    public class AdminLogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageProducts()
        {
            return View();
        }

        public ActionResult ManageOrders()
        {
            return View();
        }

        public ActionResult ManageUsers()
        {
            return View();
        }

        public ActionResult Reports()
        {
            return View();
        }

 public IActionResult login()
    {
        return View();
    }
   
 public IActionResult register()
    {
        return View();
    }

    }

