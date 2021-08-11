using System;

namespace Solutionists.Products.Contracts.Dto
{
    public class ProductDto
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
