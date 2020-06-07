using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Model.Product;
using Ecommerce.Service.Brand;
using Ecommerce.Service.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecommerce.Web.Areas.Identity.Pages.Product
{
    public class DetailModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;

        public DetailModel(IProductService productService,
            IBrandService brandService)
        {
            _productService = productService;
            _brandService = brandService;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }

        public async Task OnGetAsync(int id)
        {
            Product = await _productService.GetDetail(id);
        }
    }
}