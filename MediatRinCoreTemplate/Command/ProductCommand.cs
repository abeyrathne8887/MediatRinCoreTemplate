
using MediatR;
using MediatRinCoreTemplate.DataStore;
using MediatRinCoreTemplate.Model;
using MediatRinCoreTemplate.Query;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRinCoreTemplate.Handler.Command
{
    public class ProductCommands
    {
        public record  AddProductCommand(string title, decimal quantity) : IRequest<Guid>;

    }
}
