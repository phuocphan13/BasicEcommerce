using Ecommerce.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Product
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> Get();

        Task<ProductViewModel> GetDetail(int id);

        Task<bool> Create(ProductCreateModel product);

        Task<bool> Edit(ProductCreateModel product);
    }
}
