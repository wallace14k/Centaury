using Centaury.Domain.Entities;
using Centaury.Infra.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Centaury.Infra.Infrastructure.Repository
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly BaseContext _baseContext;
        public OfficeRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<IList<Office>> GetOfficesAsync()
        {
            try
            {
                return await _baseContext.Offices.Include(o => o.Sector).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
