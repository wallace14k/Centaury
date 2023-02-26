using AutoMapper;
using Centaury.Api.Models.Mapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeeGetRequest;

namespace Centaury.Api.Models.MapperProfile.Mapper
{
    public static class SectorMapper
    {
        public static IMapper Mapper { get; }

        static SectorMapper()
        {
            Mapper = new MapperConfiguration(x => x.AddProfile<EmployeeGetProfile>())
                .CreateMapper();

            Mapper = new MapperConfiguration(x => x.AddProfile<EmployeePostProfile>())
                .CreateMapper();
        }

        public static SectorGetRequest ToModel(this Sector sector)
        {
            return sector == null ? null : Mapper.Map<SectorGetRequest>(sector);
        }

        public static List<SectorGetRequest> ToModel(this List<Sector> sector)
        {
            return sector == null ? null : Mapper.Map<List<SectorGetRequest>>(sector);
        }

        public static Sector ToEntity(this SectorGetRequest sector)
        {
            return sector == null ? null : Mapper.Map<Sector>(sector);
        }

        public static List<Sector> ToEntity(this List<SectorGetRequest> sector)
        {
            return sector == null ? null : Mapper.Map<List<Sector>>(sector);
        }       
    }
}
