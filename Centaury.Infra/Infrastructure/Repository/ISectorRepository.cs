using Centaury.Domain.Entities;

namespace Centaury.Infra.Infrastructure.Repository
{
    public interface ISectorRepository
    {
        Task<IEnumerable<Sector>> GetOfficesAsync();
        Task<Sector> CreateSectorAsync(Sector sector);
    }
}
