


namespace project3.Controllers;

using System;
using System.Collections.Generic;

public class Order
{
    public int Id { get; set; } // Unique identifier for the order
    public DateTime OrderDate { get; set; } // Date and time when the order was placed
    public string UserId { get; set; } // ID of the user who placed the order
    public string ShippingAddress { get; set; } // Shipping address for the order
    public decimal TotalPrice { get; set; } // Total price of the order
    public List<OrderItem> OrderItems { get; set; } // List of items in the order
    public string PaymentMethod { get; set; } // Payment method used for the order
    public string PaymentStatus { get; set; } // Payment status of the order

    public Order()
    {
        OrderItems = new List<OrderItem>();
    }
}

public class OrderItem
{
    public int ProductId { get; set; } // ID of the product in the order
    public string ProductName { get; set; } // Name of the product in the order
    public decimal Price { get; set; } // Price of the product in the order
    public int Quantity { get; set; } // Quantity of the product in the order
}
