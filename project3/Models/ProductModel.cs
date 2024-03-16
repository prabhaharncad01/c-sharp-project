namespace project3.Controllers;

public class Product
{
    public int Id { get; set; } // Unique identifier for the product
    public string Name { get; set; } // Name of the product
    public string Description { get; set; } // Description of the product
    public decimal Price { get; set; } // Price of the product
    public int StockLevel { get; set; } // Stock level of the product

    // Additional properties can be added as needed, such as category, image URL, etc.
}
