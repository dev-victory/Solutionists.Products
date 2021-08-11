using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Soluitionists.Products.Core.Extensions;
using Solutionists.Products.Business;
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
            IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await productService.LoadAllProducts();
            logger.LogInformation($"Fetched {products.Count} products");

            return Ok(products.Select(x => x.ToDto()));
        }
    }
}
