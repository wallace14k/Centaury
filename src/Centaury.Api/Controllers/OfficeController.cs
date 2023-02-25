using AutoMapper;
using Centaury.Api.Models;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public OfficeController(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeGetRequest.OfficeGetRequest>> GetEmployeeAsync()
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeAsync();
                return _mapper.Map<IEnumerable<EmployeeGetRequest.OfficeGetRequest>>(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}