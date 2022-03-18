using MediatR;
using System;

namespace MediatRinCoreTemplate.Model
{
    public class Notification : INotification
    {
        public Notification(string massage)
        {
            Id = Guid.NewGuid();

            Massage =massage; ;
        }
        public Guid Id { get; set; }
        public String Massage { get; set; }

    }
}
