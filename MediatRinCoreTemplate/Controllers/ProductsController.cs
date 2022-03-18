using MediatR;
using MediatRinCoreTemplate.Handler.Command;
using MediatRinCoreTemplate.Handler.Notification;
using MediatRinCoreTemplate.Model;
using MediatRinCoreTemplate.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add(string title, Decimal quantity)
        {
            Random rnd = new Random();
            var ii = rnd.Next(100);
            var products = await _mediator.Send(new AddProductCommand(title +" - " + ii, quantity));
            await _mediator.Publish(new Notification($"Product Add - {title}"));
            return Ok( new { id = products.Id });
        }


    }
}
