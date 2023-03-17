using Centaury.Domain.Entities;
using Centaury.Api.Infra.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Centaury.Api.Infra.Infrastructure.Repository
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly BaseContext _baseContext;
        public OfficeRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<List<Office>> GetOfficesAsync()
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

        public async Task<Office> GetOfficesAsync(int id)
        {
            try
            {
                var  office = await _baseContext.Offices.FindAsync(id);
                if (office != null)
                {
                    return office;
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

        public async Task<Office> CreateOfficeAsync(Office office)
        {
            try
            {
                await _baseContext.Offices.AddAsync(office);
                await _baseContext.SaveChangesAsync();    
                return office;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
