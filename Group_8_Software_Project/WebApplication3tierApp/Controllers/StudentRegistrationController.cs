using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [AllowAnonymous]
    public class StudentRegistrationController : BaseController
    {

        private readonly IStudentRegistrationService _StudentRegistrationService;
        private readonly ILogger<StudentRegistrationController> _logger;

        public StudentRegistrationController(IStudentRegistrationService StudentRegistrationService, ILogger<StudentRegistrationController> logger)
        {
            _StudentRegistrationService = StudentRegistrationService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllStudentRegistrations")]
        public async Task<List<StudentRegistrationDto>> GetAll()
        {
            var result = await _StudentRegistrationService.GetAll();
            return result.Select(x => x.ToStudentRegistrationDto()).ToList();
        }

        [HttpGet("{StudentRegistrationId}", Name = "GetStudentRegistration")]
        public async Task<StudentRegistrationDto?> Get(int StudentRegistrationId)
        {
            var result = await _StudentRegistrationService.GetById(StudentRegistrationId);
            return result?.ToStudentRegistrationDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] StudentRegistrationDto requestDto)
        {
            var StudentRegistrationModel = requestDto.ToStudentRegistrationModel();
            return await _StudentRegistrationService.CreateStudentRegistration(StudentRegistrationModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] StudentRegistrationDto requestDto)
        {
            await _StudentRegistrationService.UpdateStudentRegistration(requestDto.ToStudentRegistrationModel());
            return Ok();
        }

        [HttpDelete, Route("{StudentRegistrationId}")]
        public async Task<IActionResult> Delete(int StudentRegistrationId)
        {
            await _StudentRegistrationService.DeleteStudentRegistration(StudentRegistrationId);
            return Ok();
        }
    }
}
