using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Soluitionists.Products.Core.Extensions;
using Solutionists.Products.Business;
using Solutionists.Products.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutionists.Products.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        private readonly ILogger<ProductController> logger;

        public ProductController(
            ILogger<ProductController> logger,
            IProductService productService
            )
        {
            this.logger = logger;
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            var products = await productService.LoadAllProducts();
            return products.Select(x => x.ToDto());
        }
    }
}
