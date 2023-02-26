using AutoMapper;
using Centaury.Api.Models.Mapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeeGetRequest;
using static Centaury.Api.Models.EmployeePostRequest;

namespace Centaury.Api.Models.MapperProfile.Mapper
{
    public static class OfficeMapper
    {
        public static IMapper Mapper { get; }

        static OfficeMapper()
        {
            Mapper = new MapperConfiguration(x => x.AddProfile<EmployeeGetProfile>())
                .CreateMapper();

            Mapper = new MapperConfiguration(x => x.AddProfile<EmployeePostProfile>())
                .CreateMapper();
        }

        public static OfficeGetRequest ToModel(this Office offices)
        {
            return offices == null ? null : Mapper.Map<OfficeGetRequest>(offices);
        }

        public static List<OfficeGetRequest> ToModel(this List<Office> offices)
        {
            return offices == null ? null : Mapper.Map<List<OfficeGetRequest>>(offices);                ;
        }

        public static Office ToEntity(this OfficeGetRequest offices)
        {
            return offices == null ? null : Mapper.Map<Office>(offices);
        }

        public static List<Office> ToEntity(this List<OfficeGetRequest> offices)
        {
            return offices == null ? null : Mapper.Map<List<Office>>(offices);
        }

        public static Office ToEntity(this OfficePostRequest offices)
        {
            return offices == null ? null : Mapper.Map<Office>(offices);
        }

        public static OfficePostRequest ToPostModel(this Office offices)
        {
            return offices == null ? null : Mapper.Map<OfficePostRequest>(offices);
        }
    }
}
