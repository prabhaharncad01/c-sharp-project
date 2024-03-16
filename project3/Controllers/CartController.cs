using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using project3.Models;
using Microsoft.Data.SqlClient;

namespace project3.Controllers
{
    [Route("Cart/Index")]
    public class CartController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            // Retrieve cart items and total price logic
            // Example: var cartItems = cartService.GetCartItems();
            //          var totalPrice = cartService.GetTotalPrice();

            // For demonstration, assuming cart items and total price are retrieved
            var cartItems = new[] { "Product1", "Product2", "Product3" };
            var totalPrice = 300.00;

            ViewBag.TotalPrice = totalPrice; // Pass total price to the view
            return View(cartItems);
        }

        [HttpPost("Add/{id}")]
        public IActionResult Add(int id, int quantity)
        {
            // Add product to cart logic
            // Example: cartService.AddToCart(id, quantity);

            // For demonstration, assuming product is added to cart
            TempData["Message"] = "Product added to cart successfully.";
            return RedirectToAction("Index");
        }

        [HttpPost("Remove/{id}")]
        public IActionResult Remove(int id)
        {
            // Remove product from cart logic
            // Example: cartService.RemoveFromCart(id);

            // For demonstration, assuming product is removed from cart
            TempData["Message"] = "Product removed from cart successfully.";
            return RedirectToAction("Index");
        }

        [HttpPost("UpdateQuantity/{id}")]
        public IActionResult UpdateQuantity(int id, int quantity)
        {
            // Update product quantity in cart logic
            // Example: cartService.UpdateQuantity(id, quantity);

            // For demonstration, assuming product quantity is updated in cart
            TempData["Message"] = "Cart updated successfully.";
            return RedirectToAction("Index");
        }

        [HttpGet("Checkout")]
        public IActionResult Checkout()
        {
            // Proceed to checkout logic
            // Example: var checkoutDetails = cartService.PrepareCheckout();

            // For demonstration, redirecting to a mock checkout page
            return RedirectToAction("Index", "Checkout");
        }
    }
}
