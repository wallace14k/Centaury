using AutoMapper;
using Centaury.Api.Models.Mapper;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using static Centaury.Api.Models.EmployeeGetRequest;
using static Centaury.Api.Models.EmployeePostRequest;
using Centaury.Api.Models.MapperProfile.Mapper;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOfficeRepository _officeRepository;

        public OfficeController(IMapper mapper, IOfficeRepository officeRepository)
        {
            _mapper = mapper;
            _officeRepository = officeRepository;
        }

        [HttpGet]
        public async Task<List<OfficeGetRequest>> GetOfficeAsync()
        {
            try
            {
                var office = await _officeRepository.GetOfficesAsync();
                return office.ToModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("{id:int}")]
        public async Task<OfficeGetRequest> GetOfficeAsync(int id)
        {
            try
            {
                var office = await _officeRepository.GetOfficesAsync(id);
                return office.ToModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<ActionResult<OfficePostRequest>> CreateOfficeAsync(OfficePostRequest officeModel)
        {
            try
            {
                var office = officeModel.ToEntity();
                if (office == null)
                {
                    return BadRequest("Invalid office model");
                }

                var createdOffice = await _officeRepository.CreateOfficeAsync(office);

                return CreatedAtAction(nameof(GetOfficeAsync), new { id = createdOffice.Id }, createdOffice.ToPostModel());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while creating the office: {ex.Message}");
            }
        }
    }
}