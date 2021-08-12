using Soluitionists.Products.Core;
using Soluitionists.Products.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<IReadOnlyDictionary<Guid, Product>> LoadAllProductsAsync()
        {
            return await Task.Run(() => ProductsData.LoadDataSet());
        }

        public async Task<Product> LoadProductByIdAsync(Guid id)
        {
            var allProducts = await Task.Run(() => ProductsData.LoadDataSet());
            allProducts.TryGetValue(id, out var product);

            return product;
        }
    }
}
