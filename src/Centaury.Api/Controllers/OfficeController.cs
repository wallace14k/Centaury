using AutoMapper;
using Centaury.Api.Models.MapperProfile.Mapper;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using static Centaury.Api.Models.EmployeePostViewModel;
using static Centaury.Api.Models.EmployeeViewModel;

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
        public async Task<ActionResult<List<OfficeViewModel>>> GetOfficeAsync()
        {
            try
            {
                var office = await _officeRepository.GetOfficesAsync();
                if (office != null && office.Any())
                {
                    return office.ToModel();
                }
                else
                {
                    return NotFound(StatusCodes.Status404NotFound);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao realizar a busca do cargo: {ex.Message}");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<OfficeViewModel>> GetOfficeAsync(int id)
        {
            try
            {
                var office = await _officeRepository.GetOfficesAsync(id);
                if (office != null)
                {
                    return office.ToModel();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao buscar Cargo: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<ActionResult<OfficePostViewModel>> CreateOfficeAsync(OfficePostViewModel officeModel)
        {
            try
            {
                var office = officeModel.ToPostEntity();
                if (office == null)
                {
                    return BadRequest("Invalid office model");
                }

                var createdOffice = await _officeRepository.CreateOfficeAsync(office);

                var result = CreatedAtAction(nameof(GetOfficeAsync), new { id = createdOffice.Id }, createdOffice.ToPostModel());

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while creating the office: {ex.Message}");
            }
        }
    }
}