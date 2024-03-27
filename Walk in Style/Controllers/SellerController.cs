using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers;
[Route("[controller]")]

    public class SellerController : Controller
    {
        

      [Route("Seller/dashboard")]
        public ActionResult dashboard()
        {
            return View("dashboard","_LayoutSeller");
        }

       
        public ActionResult ManageProducts()
        {
            return View("ManageProducts","_LayoutSeller");
        }

        public ActionResult ManageOrders()
        {
            return View("ManageOrders","_LayoutSeller");
        }

        public ActionResult ViewSales()
        {
            return View("ViewSales","_LayoutSeller");
        }

          public ActionResult ManageCustomers()
        {
            return View("ManageCustomers","_LayoutSeller");
        }

        public ActionResult ManageInventory()
        {
            return View("ManageInventory","_LayoutSeller");
        }
   

    }

