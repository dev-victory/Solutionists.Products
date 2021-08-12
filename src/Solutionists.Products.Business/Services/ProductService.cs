using Soluitionists.Products.Core.Exceptions;
using Soluitionists.Products.Core.Models;
using Solutionists.Products.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutionists.Products.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepo;

        public ProductService(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        public async Task<IReadOnlyCollection<Product>> LoadAllProducts()
        {
            var productsDict = await productRepo.LoadAllProductsAsync();
            List<Product> products = new();

            if (!productsDict?.Any() ?? true)
                throw new NotFoundException("No products found");

            foreach (var item in productsDict)
            {
                products.Add(item.Value);
            }

            return products;
        }

        public async Task<Product> LoadProductById(Guid id)
        {
            var product = await productRepo.LoadProductByIdAsync(id);

            if (product == null)
                throw new NotFoundException($"Product with id '{id}' not found");

            return product;
        }
    }
}
