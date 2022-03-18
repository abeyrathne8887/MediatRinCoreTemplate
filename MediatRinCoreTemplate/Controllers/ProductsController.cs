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
using static MediatRinCoreTemplate.Handler.Command.ProductCommands;
using static MediatRinCoreTemplate.Query.GetProductQuery;

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
            var products = await _mediator.Send(new GetAllProducts());
            return Ok(products);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add(string title, Decimal quantity)
        {
            Random rnd = new Random();
            var ii = rnd.Next(100);
            title += " - " + ii;
            var productsid = await _mediator.Send(new AddProductCommand(title, quantity));
            await _mediator.Publish(new Notification($"Product Add - {title}"));
            return Created("", new { id = productsid });
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var Product = await _mediator.Send(new GetProductById(id));
            return Ok(Product);
        }


    }
}