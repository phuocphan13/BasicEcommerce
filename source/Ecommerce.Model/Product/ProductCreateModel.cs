using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Product
{
    public class ProductCreateModel : BaseViewModel
    {
        public string Name { get; set; }

        public int BrandId { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }
    }
}
