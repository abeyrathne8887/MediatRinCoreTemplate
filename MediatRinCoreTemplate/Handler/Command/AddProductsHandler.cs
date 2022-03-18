using MediatR;
using MediatRinCoreTemplate.DataStore;
using MediatRinCoreTemplate.Handler.Command;
using MediatRinCoreTemplate.Model;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.Handler.Query
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeProductsDataStore _productsRepo;

        public AddProductHandler(FakeProductsDataStore productsRepo)
        {
            _productsRepo = productsRepo;
        }

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            await _productsRepo.AddProduct(request._product);
            return request._product;
        }

        
    }
}
