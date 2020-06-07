using Ecommerce.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Store : BaseEntityModel
    {
        public int ProductId { get; set; }

        public int Amount { get; set; }
    }
}
