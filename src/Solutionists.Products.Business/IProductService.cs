using Soluitionists.Products.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Business
{
    public interface IProductService
    {
        public Task<IReadOnlyCollection<Product>> LoadAllProducts();
    }
}
