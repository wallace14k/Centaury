using AutoMapper;
using Centaury.Domain.Entities;

namespace Centaury.Api.Models.MapperProfile.Mapper
{
    public static class ProductMapper
    {
        public static IMapper Mapper { get; }

        static ProductMapper()
        {
            Mapper = new MapperConfiguration(pfl => pfl.AddProfile<ProductProfile>())
                .CreateMapper();
        }

        public static ProductViewModel ToModel(this Product product)
        {
            return Mapper.Map<ProductViewModel>(product);
        }
        public static Product ToEntity(this ProductViewModel product)
        {
            return Mapper.Map<Product>(product);
        }
        public static List<ProductViewModel> ToModel(this List<Product> product)
        {
            return Mapper.Map<List<ProductViewModel>>(product);
        }
        public static List<Product> ToEntity(this List<ProductViewModel> product)
        {
            return Mapper.Map<List<Product>>(product);
        }
    }
}