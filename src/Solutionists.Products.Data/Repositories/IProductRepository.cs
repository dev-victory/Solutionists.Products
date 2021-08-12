using Soluitionists.Products.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Data.Repositories
{
    public interface IProductRepository
    {
        public Task<IReadOnlyDictionary<Guid, Product>> LoadAllProductsAsync();
        public Task<Product> LoadProductByIdAsync(Guid id);
    }
}
