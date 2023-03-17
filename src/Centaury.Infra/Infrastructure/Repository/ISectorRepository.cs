using Centaury.Domain.Entities;

namespace Centaury.Api.Infra.Infrastructure.Repository
{
    public interface ISectorRepository
    {
        Task<List<Sector>> GetOfficesAsync();
        Task<Sector> CreateSectorAsync(Sector sector);
        Task<Sector> GetSectorAsync(int id);
    }
}
