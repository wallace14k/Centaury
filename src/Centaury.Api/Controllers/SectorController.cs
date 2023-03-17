using Centaury.Api.Models.MapperProfile.Mapper;
using Centaury.Api.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using static Centaury.Api.Models.EmployeePostViewModel;
using static Centaury.Api.Models.EmployeeViewModel;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly ISectorRepository _sectorRepository;

        public SectorController(ISectorRepository sectorRepository)
        {
            _sectorRepository = sectorRepository;
        }
        [HttpGet]
        public async Task<List<SectorViewModel>> GetSectorAsync()
        {
            try
            {
                var sector = await _sectorRepository.GetOfficesAsync();
                if (sector != null)
                {
                    return sector.ToModel();
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
        [HttpGet("{id:int}")]
        public async Task<SectorViewModel> GetSectorById(int id)
        {
            var sector = await _sectorRepository.GetSectorAsync(id);
            return sector.ToModel();
        }

        [HttpPost]
        public async Task<ActionResult<SectorPostViewModel>> CreateSectorAsync(SectorPostViewModel sectorGetRequest)
        {

            if (sectorGetRequest != null)
            {
                var sector = sectorGetRequest.ToPostEntity();
                if (sector != null)
                {
                    return (await _sectorRepository.CreateSectorAsync(sector)).ToPostModel();
                }
                else
                {
                    return BadRequest("Erro favor contatar o administrador");
                }
            }
            else
            {
                return BadRequest("não foi possivel inserir o novo setor");
            }
        }
    }
}
