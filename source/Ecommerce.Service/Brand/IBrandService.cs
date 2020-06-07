using Ecommerce.Model.Brand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Service.Brand
{
    public interface IBrandService
    {
        Task<List<SelectListItem>> GetBrandsSelection();
    }
}
