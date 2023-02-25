using Centaury.Domain.Entities;
using Centaury.Infra.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Centaury.Infra.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly BaseContext _baseContext;
        public EmployeeRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeAsync()
        {
            try
            {
                return await _baseContext.Employees.Include(o => o.Sector).Include(x => x.Office).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
