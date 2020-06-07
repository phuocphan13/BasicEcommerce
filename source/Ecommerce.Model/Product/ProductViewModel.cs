using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ecommerce.Model.Product
{
    public class ProductViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }
    }
}
