using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Soluitionists.Products.Core.Extensions;
using Solutionists.Products.Business.Services;
using Solutionists.Products.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutionists.Products.Web.Controllers
{
    [ApiController]
    [Route("products")]
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

        // TODO: load cache time from config
        [ResponseCache(Duration = 120)]
        [Produces(typeof(IEnumerable<ProductDto>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await productService.LoadAllProducts();
            logger.LogInformation($"Fetched {products.Count} products");
            if (!products.Any()) 
            {
                return NotFound("No products found");
            }


            return Ok(products.Select(x => x.ToDto()));
        }

        // TODO: load cache time from config
        [ResponseCache(Duration = 360)]
        [Produces(typeof(ProductDto))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await productService.LoadProductById(id);
            logger.LogInformation($"Fetched product with id {id}");

            return Ok(product);
        }
    }
}
