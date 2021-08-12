using Microsoft.AspNetCore.Mvc;
using Soluitionists.Products.Core.Exceptions;
using Soluitionists.Products.Core.Extensions;
using Solutionists.Products.Business.Services;
using Solutionists.Products.Contracts.Dto;
using Solutionists.Products.Web.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutionists.Products.Web.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly ILoggerManager logger;

        public ProductController(
            ILoggerManager logger,
            IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        [ResponseCache(Duration = 120)]
        [Produces(typeof(IEnumerable<ProductDto>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var products = await productService.LoadAllProducts();
                logger.LogInformation($"Fetched {products.Count} products");

                return Ok(products.Select(x => x.ToDto()));
            }
            catch (NotFoundException ex)
            {
                logger.LogError($"Error: \n{ex.Message}");
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                logger.LogError($"Unknown Error occurred while getting all products, details: \n{ex.Message}");
                return BadRequest("Unknown error occured");
            }
        }

        [ResponseCache(Duration = 360)]
        [Produces(typeof(ProductDto))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var product = await productService.LoadProductById(id);
                logger.LogInformation($"Fetched product with id {id}");

                return Ok(product);
            }
            catch (NotFoundException ex)
            {
                logger.LogError($"Error: \n{ex.Message}");
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                logger.LogError($"Unknown error occurred while getting product by ID {id}, details: \n{ex.Message}");
                return BadRequest("Unknown error occured");
            }
        }
    }
}
