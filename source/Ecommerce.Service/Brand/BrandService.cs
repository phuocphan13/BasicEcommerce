using AutoMapper;
using Ecommerce.Core.Repositories;
using Ecommerce.Core.UoW;
using Ecommerce.Model.Brand;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Service.Brand
{
    public class BrandService : BaseService, IBrandService
    {
        private readonly IRepository<Domain.Models.Brand> _brandRepository;

        public BrandService(IUnitOfWork unitOfWork,
            IRepository<Domain.Models.Brand> brandRepository,
            IMapper mapper) : base(unitOfWork, mapper)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<SelectListItem>> GetBrandsSelection()
        {
            var brandEntities = await _brandRepository.GetAll().ToListAsync();
            var brands = new List<SelectListItem>();
            foreach (var item in brandEntities)
            {
                var brand = new SelectListItem();
                brand.Text = item.Name;
                brand.Value = item.Id.ToString();
                brands.Add(brand);
            }

            return brands;
        }
    }
}
