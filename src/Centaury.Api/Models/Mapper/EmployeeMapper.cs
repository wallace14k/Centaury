using AutoMapper;
using Centaury.Domain.Entities;

namespace Centaury.Api.Models.Mapper
{
    public class EmployeeMapper : Profile
    {
        public void EmployeeMap()
        {
            CreateMap<Employee, EmployeeGetRequest>();
            CreateMap<EmployeeGetRequest, Employee>();
            CreateMap<Office, EmployeeGetRequest.OfficeGetRequest>();
            CreateMap<EmployeeGetRequest.OfficeGetRequest, Office>();
            CreateMap<IEnumerable<Employee>, IEnumerable<EmployeeGetRequest>>();
            CreateMap<IEnumerable<EmployeeGetRequest>, IEnumerable<Employee>>();
            CreateMap<IEnumerable<Office>, IEnumerable<EmployeeGetRequest.OfficeGetRequest>>();
            CreateMap<IEnumerable<EmployeeGetRequest.OfficeGetRequest>, IEnumerable<Office>>();
        }
    }
}
