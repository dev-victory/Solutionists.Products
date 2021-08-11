using System;

namespace Soluitionists.Products.Core.Models
{
    public class Product
    {
        public Product(Guid id, string name, int stock, string image, decimal price)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Image = image;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
