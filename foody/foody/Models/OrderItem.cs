﻿using System.Net.Http.Headers;

namespace foody.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; } 
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        
    }
}
