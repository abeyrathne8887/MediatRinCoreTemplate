
using MediatR;
using MediatRinCoreTemplate.DataStore;
using MediatRinCoreTemplate.Model;
using MediatRinCoreTemplate.Query;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.Handler.Query
{
    public class GetAllNotificationHandler : IRequestHandler<GetAllNotificationQuery, IEnumerable<MediatRinCoreTemplate.Model.Notification>>
    {
        private readonly FakeNotificationDataStore _fakeDataStore;
        public GetAllNotificationHandler(FakeNotificationDataStore dataStore) => _fakeDataStore = dataStore;
        public Task<IEnumerable<MediatRinCoreTemplate.Model.Notification>> Handle(GetAllNotificationQuery request, CancellationToken cancellationToken =default(CancellationToken))
        {
            return _fakeDataStore.GetAllNotification();
        }
    }
}
