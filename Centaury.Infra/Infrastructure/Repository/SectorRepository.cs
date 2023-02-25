using Centaury.Domain.Entities;
using Centaury.Infra.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Centaury.Infra.Infrastructure.Repository
{
    public class SectorRepository : ISectorRepository
    {
        private readonly BaseContext _baseContext;
        public SectorRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<IList<Sector>> GetOfficesAsync()
        {
            try
            {
                return await _baseContext.Sector.Include(o => o.Offices).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
