using MediatR;
using MediatRinCoreTemplate.Handler.Command;
using MediatRinCoreTemplate.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MediatRinCoreTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetNotifications()
        {
            var products = await _mediator.Send(new GetAllNotificationQuery());
            return Ok(products);
        }
    }
}
