using Ecommerce.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Order : BaseEntityModel
    {
        public int CustomerId { get; set; }

        public DateTime OrderedDate { get; set; }

        public int PaymentId { get; set; }
    }
}
