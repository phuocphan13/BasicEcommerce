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
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;

        public IndexModel(IProductService productService,
            IBrandService brandService)
        {
            _productService = productService;
            _brandService = brandService;
        }

        [BindProperty]
        public List<ProductViewModel> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _productService.Get();
        }
    }
}