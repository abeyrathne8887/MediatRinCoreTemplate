using MediatRinCoreTemplate.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.DataStore
{
    public class FakeNotificationDataStore
    {
        private static List<Notification> _Notification = new List<Notification>();

        public async Task AddNotification(Notification notification)
        {
            _Notification.Add(notification);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Notification>> GetAllNotification()
        {
            return await Task.FromResult(_Notification);
        }
    }
}
