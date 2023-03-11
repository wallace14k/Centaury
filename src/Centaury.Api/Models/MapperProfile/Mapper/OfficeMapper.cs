using AutoMapper;
using Centaury.Api.Models.Mapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeePostViewModel;
using static Centaury.Api.Models.EmployeeViewModel;

namespace Centaury.Api.Models.MapperProfile.Mapper
{
    public static class OfficeMapper
    {
        public static IMapper Mapper { get; }

        static OfficeMapper()
        {
            Mapper = new MapperConfiguration(x => x.AddProfile<EmployeeProfile>())
                .CreateMapper();          
        }
        public static OfficeViewModel ToModel(this Office offices)
        {
            return  Mapper.Map<OfficeViewModel>(offices);
        }
        public static List<OfficeViewModel> ToModel(this List<Office> offices)
        {
            return  Mapper.Map<List<OfficeViewModel>>(offices);                
        }
        public static Office ToEntity(this OfficeViewModel offices)
        {
            return  Mapper.Map<Office>(offices);
        }
        public static List<Office> ToEntity(this List<OfficeViewModel> offices)
        {
            return Mapper.Map<List<Office>>(offices);
        }
        //Post
        public static OfficePostViewModel ToPostModel(this Office offices)
        {
            return Mapper.Map<OfficePostViewModel>(offices);
        }       
        public static Office ToPostEntity(this OfficePostViewModel officePostViewModel)
        {
            return Mapper.Map<Office>(officePostViewModel);
        }
    }
}
