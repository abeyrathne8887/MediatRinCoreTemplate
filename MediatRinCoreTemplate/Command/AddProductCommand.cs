
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
    public class AddProductCommand : IRequest<Product>
    {
       public readonly Product _product;

        public AddProductCommand(string title, decimal quantity)
        {
            _product=new Product();
            _product.Id = Guid.NewGuid();
            _product.Title = title;
            _product.Qunatity = quantity;
        }
    }
}
