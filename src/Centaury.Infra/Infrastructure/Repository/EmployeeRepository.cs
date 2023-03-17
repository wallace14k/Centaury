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

        public async Task<List<Employee>> GetEmployeeAsync()
        {
            try
            {
                var employees = await _baseContext.Employees
                    .Include(s => s.Sector)
                        .Include(o => o.Office)
                            .ToListAsync();

                if (employees != null && employees.Any())
                {
                    return employees;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task <Employee> GetEmployeeByIdAsync(int id)
        {
            try
            {
                var employee = await _baseContext.Employees.FindAsync(id);
                if(employee != null)
                {
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Employee> CreateEmplyeeAsync(Employee employee)
        {
            try
            {
                if (employee != null)
                {
                    await _baseContext.AddAsync(employee);
                    await _baseContext.SaveChangesAsync();
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
