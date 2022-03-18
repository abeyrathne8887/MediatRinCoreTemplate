using System;

namespace MediatRinCoreTemplate.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Decimal Qunatity { get; set; }
    }
}
