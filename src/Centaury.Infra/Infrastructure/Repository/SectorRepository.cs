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

        public async Task<List<Sector>> GetOfficesAsync()
        {
            try
            {
                return await _baseContext.Sector.Include(x => x.Offices).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<Sector> GetSectorAsync(int id)
        {
            try
            {
                return await _baseContext.Sector.FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Sector> CreateSectorAsync(Sector sector)
        {
            try
            {
                await _baseContext.Sector.AddAsync(sector);
                _baseContext.SaveChanges();
                return sector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
