using Centaury.Api.Infra.Infrastructure.Repository;
using Centaury.Api.Models;
using Centaury.Api.Models.MapperProfile.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductViewModel>>> GetProductsAsync()
        {
            try
            {
                var product = await _productRepository.GetAllProductAsync();
                if (product == null)
                {
                    return BadRequest("Erro ao Buscar os funcionários");
                }
                return Ok(product.ToModel());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Um erro ocorreu ao buscar os funcionários : {ex.Message}");
            }
        }
    }
}
