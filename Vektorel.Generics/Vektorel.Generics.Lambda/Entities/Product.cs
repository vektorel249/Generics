﻿namespace Vektorel.Generics.Lambda.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, decimal price, int stock, string supplier, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Supplier = supplier;
            Category = category;
        }
    }
}
