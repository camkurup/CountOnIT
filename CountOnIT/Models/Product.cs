﻿namespace CountOnIT.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int StockQuantity { get; set; }

        public Product(int id, string name, string description, string imageUrl, int stockQuantity)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            StockQuantity = stockQuantity;
        }
    }
}
