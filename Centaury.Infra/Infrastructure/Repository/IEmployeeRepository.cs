using Centaury.Domain.Entities;

namespace Centaury.Infra.Infrastructure.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeeAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> CreateEmplyeeAsync(Employee employee);
    }
}
