using AutoMapper;
using Centaury.Domain.Entities;
using static Centaury.Api.Models.EmployeePostViewModel;
using static Centaury.Api.Models.EmployeeViewModel;

namespace Centaury.Api.Models.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            GetEmployeeMap();
            PostEmployeeMap();
        }
        public void GetEmployeeMap()
        {
            CreateMap<Employee, EmployeeViewModel>(MemberList.Destination)
                .ConstructUsing(src => new EmployeeViewModel());

            CreateMap<EmployeeViewModel, Employee>(MemberList.Destination)
               .ConstructUsing(src => new Employee());

            CreateMap<Sector, SectorViewModel>(MemberList.Destination) 
                .ConstructUsing(src => new SectorViewModel());

            CreateMap<SectorViewModel, Sector>(MemberList.Destination)
                .ConstructUsing(src => new Sector());

            CreateMap<Office, OfficeViewModel>(MemberList.Destination)
                .ForMember(x => x.Name, y => y.MapFrom(opt => opt.Name))
                .ForMember(x => x.Sector, y => y.MapFrom(opt => opt.Sector))                
               .ConstructUsing(src => new OfficeViewModel());

            CreateMap<OfficeViewModel, Office>(MemberList.Destination)
                .ConstructUsing(src => new Office());
        }
        public void PostEmployeeMap()
        {
            CreateMap<Employee, EmployeePostViewModel>(MemberList.Destination)
               .ConstructUsing(src => new EmployeePostViewModel());

            CreateMap<EmployeePostViewModel, Employee>(MemberList.Destination)
               .ConstructUsing(src => new Employee());

            CreateMap<OfficePostViewModel, Office>(MemberList.Destination)                         
                          .ConstructUsing(src => new Office());

            CreateMap<Office, OfficePostViewModel>(MemberList.Destination)
                .ConstructUsing(src => new OfficePostViewModel());

            CreateMap<SectorPostViewModel, Sector>(MemberList.Destination)
                .ConstructUsing(src => new Sector());

            CreateMap<Sector, SectorPostViewModel>(MemberList.Destination)
                .ConstructUsing(src => new SectorPostViewModel());
        }
    }
}
