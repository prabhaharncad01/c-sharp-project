using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers;

    public class SellerLogController : Controller
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

        public ActionResult ViewSales()
        {
            return View();
        }

          public ActionResult ManageCustomers()
        {
            return View();
        }

        public ActionResult ManageInventory()
        {
            return View();
        }

    }

