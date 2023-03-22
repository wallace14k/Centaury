using Centaury.Api.Infra.Infrastructure.Context;
using Centaury.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Centaury.Api.Infra.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly BaseContext _baseCotext;
        public ProductRepository(BaseContext baseContext)
        {
            _baseCotext = baseContext;
        }
        public async Task<List<Product>> GetAllProductAsync()
        {
            try
            {
                var products = await _baseCotext.Products.Include(x => x.Sector).ToListAsync();
                if (products != null && products.Any())
                {
                    return products;
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
        public async Task<Product> GetProductAsync(int id)
        {
            try
            {
                var product = await _baseCotext.Products.FindAsync(id);
                if (product != null)
                {
                    return product;
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
        public async Task<Product> AddProsuctAsync(Product product)
        {
            try
            {
                await _baseCotext.AddAsync(product);
                await _baseCotext.SaveChangesAsync();
                if (_baseCotext.SaveChangesAsync().Status == 0)
                {                   
                    return product;
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
