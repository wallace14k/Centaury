using AutoMapper;
using Centaury.Domain.Entities;

namespace Centaury.Api.Models.MapperProfile
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            GetProductMap();
        }
        public void GetProductMap()
        {
            CreateMap<Product, ProductViewModel>(MemberList.Destination)
                .ConstructUsing(src => new ProductViewModel());

            CreateMap<ProductViewModel, Product>(MemberList.Destination)
                .ConstructUsing(src => new Product());

            CreateMap<List<Product>, List<ProductViewModel>>(MemberList.Destination)
                .ConstructUsing(src => new List<ProductViewModel>());

            CreateMap<List<ProductViewModel>, List<Product>>(MemberList.Destination)
                .ConstructUsing(src => new List<Product>());
        }
    }
}
