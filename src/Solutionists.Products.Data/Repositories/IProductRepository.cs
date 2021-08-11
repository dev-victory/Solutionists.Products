using Soluitionists.Products.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Data.Repositories
{
    public interface IProductRepository
    {
        public Task<IReadOnlyDictionary<Guid, Product>> LoadAllProductsAsync();
    }
}
