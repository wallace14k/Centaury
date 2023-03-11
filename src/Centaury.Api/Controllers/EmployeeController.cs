using AutoMapper;
using Centaury.Api.Models;
using Centaury.Api.Models.MapperProfile.Mapper;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using static Centaury.Api.Models.EmployeePostViewModel;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeViewModel>>> GetEmployeeAsync()
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeAsync();
                if (employee == null)
                {
                    return BadRequest("Erro ao Buscar os funcionários");
                }
                return Ok(employee.ToModel());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Um erro ocorreu ao buscar os funcionários : {ex.Message}");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeViewModel>> GetOfficeAsync(int id)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeByIdAsync(id);
                if (employee != null)
                {
                    return Ok(employee.ToModel());
                }
                else
                {
                    return BadRequest("Erro ao Buscar os funcionários");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Um erro ocorreu ao buscar os funcionários : {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<ActionResult<EmployeePostViewModel>> CreateOfficeAsync(EmployeePostViewModel officeModel)
        {
            try
            {
                var office = officeModel.ToPostEntity();
                if (office == null)
                {
                    return BadRequest("Invalid office model");
                }

                var createdOffice = await _employeeRepository.CreateEmplyeeAsync(office);

                var result = CreatedAtAction(nameof(GetOfficeAsync), new { id = createdOffice.Id }, createdOffice.ToPostModel());

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Um erro ocorreu ao criar o funcionário: {ex.Message}");
            }
        }
    }
}
