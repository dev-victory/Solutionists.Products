using Soluitionists.Products.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Business.Services
{
    public interface IProductService
    {
        public Task<IReadOnlyCollection<Product>> LoadAllProducts();
        public Task<Product> LoadProductById(Guid id);
    }
}
