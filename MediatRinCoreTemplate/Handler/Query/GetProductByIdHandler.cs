using MediatR;
using MediatRinCoreTemplate.DataStore;
using MediatRinCoreTemplate.Model;
using MediatRinCoreTemplate.Query;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static MediatRinCoreTemplate.Query.GetProductQuery;


namespace MediatRinCoreTemplate.Handler.Query
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
    {
        private readonly FakeProductsDataStore _fakeDataStore;

        public GetProductByIdHandler(FakeProductsDataStore dataStore) => _fakeDataStore = dataStore;

        public async Task<Product> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetById(request.id);
        }
    }
}
