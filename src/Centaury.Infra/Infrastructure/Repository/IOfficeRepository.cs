using Centaury.Domain.Entities;

namespace Centaury.Api.Infra.Infrastructure.Repository
{
    public interface IOfficeRepository
    {
        Task<List<Office>> GetOfficesAsync();
        Task<Office> GetOfficesAsync(int id);
        Task<Office> CreateOfficeAsync(Office office);
    }
}
