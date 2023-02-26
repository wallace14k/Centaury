using AutoMapper;
using Centaury.Api.Models.MapperProfile.Mapper;
using Centaury.Domain.Entities;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using static Centaury.Api.Models.EmployeeGetRequest;
using static Centaury.Api.Models.EmployeePostRequest;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly ISectorRepository _sectorRepository;
        private readonly IMapper _mapper;

        public SectorController(ISectorRepository sectorRepository, IMapper mapper)
        {
            _sectorRepository = sectorRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<List<SectorGetRequest>> GetSectorAsync()
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
        public async Task<SectorGetRequest> GetSectorById(int id)
        {
            try
            {
                var sector = await _sectorRepository.GetSectorAsync(id);
                return sector.ToModel();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<SectorPostRequest> CreateSectorAsync(SectorPostRequest SectorGetRequest)
        {
            try
            {

                if (SectorGetRequest != null)
                {
                    var sector = _mapper.Map<Sector>(SectorGetRequest);
                    if (sector != null)
                    {
                        return _mapper.Map<SectorPostRequest>(await _sectorRepository.CreateSectorAsync(sector));
                    }
                    else
                    {
                        return null;
                    }
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
    }
}
