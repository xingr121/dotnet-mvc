﻿using System.ComponentModel;

namespace foody.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<ProductIngredient>? ProductIngredients { get; set;}
      
    }
    
}