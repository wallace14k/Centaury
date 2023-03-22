using Centaury.Domain.Entities;

namespace Centaury.Api.Infra.Infrastructure.Repository
{
    public interface IProductRepository
    {
         Task<List<Product>> GetAllProductAsync();
         Task<Product> GetProductAsync(int id);
         Task<Product> AddProsuctAsync(Product product);
    }
}
