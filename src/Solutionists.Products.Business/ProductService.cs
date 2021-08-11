using Soluitionists.Products.Core;
using Solutionists.Products.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Business
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
            var products = new List<Product>();

            foreach (var item in productsDict)
            {
                products.Add(item.Value);
            }

            return products;
        }
    }
}
