using MediatR;
using MediatRinCoreTemplate.DataStore;
using MediatRinCoreTemplate.Handler.Command;
using MediatRinCoreTemplate.Model;
using System;
using System.Threading;
using System.Threading.Tasks;
using static MediatRinCoreTemplate.Handler.Command.ProductCommands;

namespace MediatRinCoreTemplate.Handler.Query
{

    public class ProductHandler 
    {

        public record AddProductHandler : IRequestHandler<AddProductCommand, Guid>
        {
            //To Do
            //need to use repository 
            private readonly FakeProductsDataStore _productsRepo;
            public AddProductHandler(FakeProductsDataStore productsRepo)=> _productsRepo = productsRepo;
            public async Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken = default(CancellationToken))
            {
                Product product = new Product();
                product.Title = request.title;
                product.Qunatity = request.quantity;
                product.Id = Guid.NewGuid();

                await _productsRepo.AddProduct(product);
                return product.Id;
            }

        }
        


    }
}

