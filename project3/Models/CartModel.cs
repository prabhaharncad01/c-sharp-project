using System.Collections.Generic;

public class Cart
{
    public List<CartItem> Items { get; set; } // List of items in the cart
    public decimal TotalPrice { get; set; } // Total price of all items in the cart

    public Cart()
    {
        Items = new List<CartItem>();
        TotalPrice = 0;
    }
}

public class CartItem
{
    public int ProductId { get; set; } // ID of the product in the cart
    public string ProductName { get; set; } // Name of the product in the cart
    public decimal Price { get; set; } // Price of the product in the cart
    public int Quantity { get; set; } // Quantity of the product in the cart
}
