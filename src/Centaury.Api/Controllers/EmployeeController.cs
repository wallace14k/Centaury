using AutoMapper;
using Centaury.Api.Models;
using Centaury.Infra.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Centaury.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOfficeRepository _officeRepository;

        public EmployeeController(IMapper mapper, IOfficeRepository officeRepository)
        {
            _mapper = mapper;
            _officeRepository = officeRepository;
        }

        [HttpGet]
        public async Task<EmployeeGetRequest> GetEmployeeAsync()
        {
            try
            {
                var employee = _officeRepository.GetOfficesAsync().Result.AsEnumerable().FirstOrDefault();       
                return _mapper.Map<EmployeeGetRequest>(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
