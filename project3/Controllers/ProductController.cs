using Microsoft.AspNetCore.Mvc;

namespace project3.Controllers
{
    [Route("Product/Index")]
    public class ProductController : Controller
    {
        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            // Retrieve product details by id from the database
            // You might implement this logic here or call a service/repository method
            // Example: var product = productService.GetProductById(id);

            // For demonstration, assuming a product object is retrieved
            var product = new Product { Id = id, Name = "Sample Product", Price = 100.00 };

            return View(product);
        }

        [HttpGet("Search")]
        public IActionResult Search(string query)
        {
            // Perform product search logic
            // Example: var searchResults = productService.SearchProducts(query);

            // For demonstration, assuming search results are retrieved
            var searchResults = new[] { "Product1", "Product2", "Product3" };

            return View(searchResults);
        }

        [HttpPost("AddToCart/{id}")]
        public IActionResult AddToCart(int id, int quantity)
        {
            // Add product to the cart logic
            // Example: cartService.AddProductToCart(id, quantity);

            // For demonstration, assuming product is added to cart
            TempData["Message"] = "Product added to cart successfully.";
            return RedirectToAction("Details", new { id = id });
        }
    }
}
