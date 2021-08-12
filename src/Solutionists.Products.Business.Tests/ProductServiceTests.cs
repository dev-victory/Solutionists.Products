using Moq;
using Soluitionists.Products.Core;
using Soluitionists.Products.Core.Exceptions;
using Soluitionists.Products.Core.Models;
using Solutionists.Products.Business.Services;
using Solutionists.Products.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Solutionists.Products.Business.Tests
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductRepository> mockProductRepository = new();
        private ProductService productService;
        private readonly IReadOnlyDictionary<Guid, Product> testProductsData;
        private readonly IReadOnlyDictionary<Guid, Product> emptyDataSet;

        public ProductServiceTests()
        {
            testProductsData = ProductsData.LoadDataSet();
            emptyDataSet = null;
        }

        [Fact]
        public async Task LoadAllProducts_HasDataSet_ReturnsProductList()
        {
            mockProductRepository
                .Setup(x => x.LoadAllProductsAsync())
                .Returns(Task.Run(() => testProductsData));

            productService = new ProductService(mockProductRepository.Object);

            var result = await productService.LoadAllProducts();
            Assert.Equal(testProductsData.Count, result.Count);
            Assert.Equal(testProductsData.First().Key, result.First().Id);
        }

        [Fact]
        public async Task LoadAllProducts_HasNoData_ReturnsProductList()
        {
            mockProductRepository
                .Setup(x => x.LoadAllProductsAsync())
                .Returns(Task.Run(() => emptyDataSet));

            productService = new ProductService(mockProductRepository.Object);

            await Assert.ThrowsAsync<NotFoundException>(async () => await productService.LoadAllProducts());
        }

        [Fact]
        public async Task LoadProductById_ValidId_ReturnsProduct()
        {
            var id = testProductsData.First().Key;
            mockProductRepository
                .Setup(x => x.LoadProductByIdAsync(id))
                .Returns(Task.Run(() => testProductsData.First().Value));

            productService = new ProductService(mockProductRepository.Object);

            var result = await productService.LoadProductById(id);
            Assert.Equal(testProductsData.First().Key, result.Id);
        }

        [Fact]
        public async Task LoadProductById_InvalidId_ReturnsProduct()
        {
            var id = Guid.Empty;
            mockProductRepository
                .Setup(x => x.LoadProductByIdAsync(id))
                .Returns(Task.FromResult((Product)null));

            productService = new ProductService(mockProductRepository.Object);

            await Assert.ThrowsAsync<NotFoundException>(
                async () => await productService.LoadProductById(id));
        }
    }
}
