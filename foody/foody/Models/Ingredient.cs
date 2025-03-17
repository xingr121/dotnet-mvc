﻿namespace foody.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductIngredient> ProductIngredients { get; set; }
        public int CategoryId { get; internal set; }
    }
}