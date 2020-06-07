using AutoMapper;
using Ecommerce.Core.Extensions;
using Ecommerce.Core.Repositories;
using Ecommerce.Core.UoW;
using Ecommerce.Model.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Product
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IRepository<Domain.Models.Product> _productRepository;
        private readonly IRepository<Domain.Models.Brand> _brandRepository;

        public ProductService(IUnitOfWork unitOfWork,
            IRepository<Domain.Models.Product> productRepository,
            IRepository<Domain.Models.Brand> brandRepository,
            IMapper mapper) : base(unitOfWork, mapper)
        {
            _productRepository = productRepository;
            _brandRepository = brandRepository;
        }

        public async Task<List<ProductViewModel>> Get()
        {
            var listProducts = new List<ProductViewModel>();
            var listProductEntities = await _productRepository.GetAll().ToListAsync();

            var brandIds = listProductEntities.Select(x => x.BrandId);
            var listBrandEntities = await _brandRepository.GetAll().Where(x => brandIds.Any(i => i == x.Id)).ToListAsync();

            foreach (var entity in listProductEntities)
            {
                var product = new ProductViewModel();
                var brand = listBrandEntities.FirstOrDefault(x => x.Id == entity.BrandId);

                product = _mapper.Map<Domain.Models.Product, ProductViewModel>(entity);
                product.BrandId = brand.Id;
                product.BrandName = brand.Name;

                listProducts.Add(product);
            }

            return listProducts;
        }

        public async Task<ProductViewModel> GetDetail(int id)
        {
            var product = new ProductViewModel();
            var productEntity = await _productRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
            var brandEntity = await _brandRepository.GetAll().FirstOrDefaultAsync(x => x.Id == productEntity.BrandId);

            product = _mapper.Map<Domain.Models.Product, ProductViewModel>(productEntity);
            product.BrandId = brandEntity.Id;
            product.BrandName = brandEntity.Name;

            return product;
        }

        public async Task<bool> Create(ProductCreateModel product)
        {
            var productEntity = _mapper.Map<ProductCreateModel, Domain.Models.Product>(product);
            await _productRepository.InsertAsync(productEntity);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> Edit(ProductCreateModel product)
        {
            var productEntity = await _productRepository.FirstOrDefaultAsync(x => x.Id == product.Id);
            if (productEntity == null)
                return false;
            productEntity = _mapper.Map<ProductCreateModel, Domain.Models.Product>(product);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
