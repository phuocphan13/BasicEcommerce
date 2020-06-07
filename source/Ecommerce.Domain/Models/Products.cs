using Ecommerce.Core;
using System;
using System.Collections.Generic;

namespace Ecommerce.Domain.Models
{
    public partial class Product : BaseEntityModel
    {
        public string Name { get; set; }

        public int BrandId { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }
    }
}
