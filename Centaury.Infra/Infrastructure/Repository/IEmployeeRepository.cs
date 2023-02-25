using Centaury.Domain.Entities;

namespace Centaury.Infra.Infrastructure.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeeAsync();
    }
}
