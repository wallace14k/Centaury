using AutoMapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeePostRequest;

namespace Centaury.Api.Models.Mapper
{
    public class EmployeePostProfile : Profile
    {
        public EmployeePostProfile()
        {
            EmployeeMap();
        }

        public void EmployeeMap()
        {
            CreateMap<OfficePostRequest, Office>(MemberList.Destination)
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Sector, opt => opt.Ignore())
               .ConstructUsing(src => new Office());           
        }
    }
}
