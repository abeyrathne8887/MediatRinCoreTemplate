using MediatR;
using MediatRinCoreTemplate.Model;
using System.Collections.Generic;


namespace MediatRinCoreTemplate.Query
{
    public class GetAllNotificationQuery : IRequest<IEnumerable<Notification>>
    {
    }

  
}
