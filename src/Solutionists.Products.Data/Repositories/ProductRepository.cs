using Soluitionists.Products.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solutionists.Products.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        public async Task<IReadOnlyDictionary<Guid,Product>> LoadAllProductsAsync() 
        {
            return await Task.Run(()=> ProductsData.LoadDataSet());
        }
    }
}
