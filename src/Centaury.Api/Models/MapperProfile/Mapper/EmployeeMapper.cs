using AutoMapper;
using Centaury.Api.Models.Mapper;
using Centaury.Domain.Entities;

namespace Centaury.Api.Models.MapperProfile.Mapper
{
    public static class EmployeeMapper
    {
        public static IMapper Mapper { get; }

        static EmployeeMapper()
        {
            Mapper = new MapperConfiguration(opt => opt.AddProfile<EmployeeProfile>())
                .CreateMapper();
        }

        public static EmployeeViewModel ToModel(this Employee employee)
        {
            return Mapper.Map<EmployeeViewModel>(employee);
        }
        public static Employee ToEntity(this EmployeeViewModel employee)
        {
            return Mapper.Map<Employee>(employee);
        }
        public static List<EmployeeViewModel> ToModel(this List<Employee> employee)
        {
            return Mapper.Map<List<EmployeeViewModel>>(employee);
        }
        public static List<Employee> ToEntity(this List<EmployeeViewModel> employee)
        {
            return Mapper.Map<List<Employee>>(employee);
        }
        //post
        public static Employee ToPostEntity(this EmployeePostViewModel employee)
        {
            return Mapper.Map<Employee>(employee);
        }
        public static EmployeePostViewModel ToPostModel(this Employee employee)
        {
            return Mapper.Map<EmployeePostViewModel>(employee);
        }
    }
}
