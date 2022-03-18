using MediatRinCoreTemplate.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.DataStore
{
    public class FakeProductsDataStore
    {
        private static List<Product> _products;
        public FakeProductsDataStore()
        {
            _products = new List<Product>
        {
            new Product { Id = System.Guid.NewGuid(), Title = "Test Product 1" ,Qunatity=100},
            new Product { Id = System.Guid.NewGuid(), Title = "Test Product 2" ,Qunatity=50},
            new Product { Id = System.Guid.NewGuid(), Title = "Test Product 3" ,Qunatity=10}
        };
        }
        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_products);
        } 
    }
}
