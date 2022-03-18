using MediatR;
using MediatRinCoreTemplate.Model;
using System;
using System.Collections.Generic;

namespace MediatRinCoreTemplate.Query
{
    public class GetProductQuery
    {
        public record GetAllProducts() : IRequest<IEnumerable<Product>>;
        public record GetProductById(Guid id) : IRequest<Product>;

    }
}
