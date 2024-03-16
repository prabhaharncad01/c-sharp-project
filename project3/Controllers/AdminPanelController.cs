using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using project3.Models;
using Microsoft.Data.SqlClient;

namespace project3.Controllers
{
    [Route("AdminPanel")]
    public class AdminPanelController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            // Logic to check if user is an administrator
            // Example: var isAdmin = userService.IsUserAdmin();

            // For demonstration, assuming user is an administrator
            var isAdmin = true;

            if (!isAdmin)
            {
                return RedirectToAction("Login", "Account"); // Redirect to login page if user is not an admin
            }

            // Assuming user is an admin, return admin panel page
            return View();
        }

        [HttpGet("ManageProducts")]
        public IActionResult ManageProducts()
        {
            // Logic to fetch and display products for management
            // Example: var products = productService.GetAllProducts();

            // For demonstration, returning a view with products for management
            var products = new[] { "Product1", "Product2", "Product3" };
            return View(products);
        }

        [HttpGet("ManageCategories")]
        public IActionResult ManageCategories()
        {
            // Logic to fetch and display categories for management
            // Example: var categories = categoryService.GetAllCategories();

            // For demonstration, returning a view with categories for management
            var categories = new[] { "Category1", "Category2", "Category3" };
            return View(categories);
        }

        [HttpGet("ManageOrders")]
        public IActionResult ManageOrders()
        {
            // Logic to fetch and display orders for management
            // Example: var orders = orderService.GetAllOrders();

            // For demonstration, returning a view with orders for management
            var orders = new[] { "Order1", "Order2", "Order3" };
            return View(orders);
        }

        [HttpGet("ManageUsers")]
        public IActionResult ManageUsers()
        {
            // Logic to fetch and display users for management
            // Example: var users = userService.GetAllUsers();

            // For demonstration, returning a view with users for management
            var users = new[] { "User1", "User2", "User3" };
            return View(users);
        }
    }
}
