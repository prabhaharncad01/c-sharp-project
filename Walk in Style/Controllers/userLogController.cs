using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers;


    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

   
        public ActionResult ViewProfile()
        {
            return View();
        }

        public ActionResult ViewOrders()
        {
            return View();
        }

        public ActionResult ViewCart()
        {
            return View();
        }

        public ActionResult EditProfile()
        {
            return View();
        }

       
    }

