using MediatR;
using MediatRinCoreTemplate.DataStore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.Handler.Notification
{
    public class NotificationEventHandler : INotificationHandler<MediatRinCoreTemplate.Model.Notification>, IDisposable
    {
        private readonly FakeNotificationDataStore _fakeNotificationDataStore;

        public NotificationEventHandler(FakeNotificationDataStore fakeNotificationDataStore) => _fakeNotificationDataStore = fakeNotificationDataStore;
        public void Dispose()
        {
            Console.WriteLine("NotificationEventHandler - Dispose");
        }

        public async Task Handle(Model.Notification notification, CancellationToken cancellationToken)
        {
            await _fakeNotificationDataStore.AddNotification(notification);
            Console.WriteLine("NotificationEventHandler - ");
        }
    }
}
