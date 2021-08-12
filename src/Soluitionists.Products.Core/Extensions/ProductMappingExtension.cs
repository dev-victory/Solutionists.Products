using Soluitionists.Products.Core.Models;
using Solutionists.Products.Contracts.Dto;

namespace Soluitionists.Products.Core.Extensions
{
    public static class ProductMappingExtension
    {
        public static ProductDto ToDto(this Product product) 
        {
            return new ProductDto
            {
                Id = product.Id,
                Image = product.Image,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }
    }
}
