using MediatR;
using MediatRinCoreTemplate.DataStore;
using MediatRinCoreTemplate.Model;
using MediatRinCoreTemplate.Query;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.Handler.Query
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeProductsDataStore _fakeDataStore;

        public GetAllProductsHandler(FakeProductsDataStore dataStore) => _fakeDataStore = dataStore;
        public Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
           return _fakeDataStore.GetAllProducts();
        }
    }
}
