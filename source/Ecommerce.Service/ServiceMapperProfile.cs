using AutoMapper;
using Ecommerce.Model.Brand;
using Ecommerce.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service
{
    public class ServiceMapperProfile : Profile
    {
        public ServiceMapperProfile()
        {
            CreateMap<Domain.Models.Product, ProductViewModel>().ReverseMap();
            CreateMap<Domain.Models.Product, ProductCreateModel>().ReverseMap();

            CreateMap<Domain.Models.Brand, BrandSelectionViewModel>()
                .ForMember(x => x.BrandName, opt => opt.MapFrom(i => i.Name))
                .ReverseMap();
        }
    }
}
