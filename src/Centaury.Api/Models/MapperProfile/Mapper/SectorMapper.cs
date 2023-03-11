using AutoMapper;
using Centaury.Api.Models.Mapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeePostViewModel;
using static Centaury.Api.Models.EmployeeViewModel;

namespace Centaury.Api.Models.MapperProfile.Mapper
{
    public static class SectorMapper
    {
        public static IMapper Mapper { get; }

        static SectorMapper()
        {
            Mapper = new MapperConfiguration(x => x.AddProfile<EmployeeProfile>())
                .CreateMapper();
        }

        public static SectorViewModel ToModel(this Sector sector)
        {
            return Mapper.Map<SectorViewModel>(sector);
        }

        public static List<SectorViewModel> ToModel(this List<Sector> sector)
        {
            return  Mapper.Map<List<SectorViewModel>>(sector);
        }

        public static Sector ToEntity(this SectorViewModel sector)
        {
            return  Mapper.Map<Sector>(sector);
        }

        public static List<Sector> ToEntity(this List<SectorViewModel> sector)
        {
            return  Mapper.Map<List<Sector>>(sector);
        } 
        //Post
        public static SectorPostViewModel ToPostModel(this Sector sector)
        {
            return Mapper.Map<SectorPostViewModel>(sector);
        }
        public static Sector ToPostEntity(this SectorPostViewModel sector)
        {
            return Mapper.Map<Sector>(sector);
        }
    }
}
