using AutoMapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeeGetRequest;

namespace Centaury.Api.Models.Mapper
{
    public class EmployeeGetProfile : Profile
    {
        public EmployeeGetProfile()
        {
            EmployeeMap();
        }
        public void EmployeeMap()
        {

            CreateMap<Sector, SectorGetRequest>(MemberList.Destination)
                .ConstructUsing(src => new SectorGetRequest());

            CreateMap<SectorGetRequest, Sector>(MemberList.Destination)
                .ConstructUsing(src => new Sector());

            CreateMap<Office, OfficeGetRequest>(MemberList.Destination)
                .ForMember(x => x.Name, y => y.MapFrom(opt => opt.Name))
                .ForMember(x => x.SectorGetRequest, y => y.MapFrom(opt => opt.Sector))                
               .ConstructUsing(src => new OfficeGetRequest());

            CreateMap<OfficeGetRequest, Office>(MemberList.Destination)
                .ConstructUsing(src => new Office());
        }
    }
}
