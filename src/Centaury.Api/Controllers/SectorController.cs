using AutoMapper;
using Centaury.Api.Models;
using Centaury.Domain.Entities;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IEnumerable<EmployeeGetRequest.SectorGetRequest>> GetSectorAsync()
        {
            try
            {
                var sector = await _sectorRepository.GetOfficesAsync();
                if (sector != null)
                {
                    return _mapper.Map<IEnumerable<EmployeeGetRequest.SectorGetRequest>>(sector);
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
        [HttpPost]
        public async Task<EmployeeGetRequest.SectorGetRequest> CreateSectorAsync(EmployeeGetRequest.SectorGetRequest SectorGetRequest)
        {
            try
            {

                if (SectorGetRequest != null)
                {
                    var sector = _mapper.Map<Sector>(SectorGetRequest);
                    if (sector != null)
                    {
                        return _mapper.Map<EmployeeGetRequest.SectorGetRequest>(await _sectorRepository.CreateSectorAsync(sector));
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
