using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers;
[Route("[controller]")]


    public class UserController : Controller
    {
         

      [Route("User/dashboard")]
        public ActionResult dashboard()
        {
            return View("dashboard","_LayoutUser");
        }

   
        public ActionResult ViewProfile()
        {
            return View("ViewProfile","_LayoutUser");
        }

        public ActionResult ViewOrders()
        {
            return View("ViewOrders","_LayoutUser");
        }

        public ActionResult ViewCart()
        {
            return View("ViewCart","_LayoutUser");
        }

        public ActionResult EditProfile()
        {
            return View("EditProfile","_LayoutUser");
        }
     
       
    }
    


    

