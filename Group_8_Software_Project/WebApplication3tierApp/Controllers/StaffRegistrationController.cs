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
    public class StaffRegistrationController : BaseController
    {

        private readonly IStaffRegistrationService _StaffRegistrationService;
        private readonly ILogger<StaffRegistrationController> _logger;

        public StaffRegistrationController(IStaffRegistrationService StaffRegistrationService, ILogger<StaffRegistrationController> logger)
        {
            _StaffRegistrationService = StaffRegistrationService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllStaffRegistrations")]
        public async Task<List<StaffRegistrationDto>> GetAll()
        {
            var result = await _StaffRegistrationService.GetAll();
            return result.Select(x => x.ToStaffRegistrationDto()).ToList();
        }

        [HttpGet("{StaffRegistrationId}", Name = "GetStaffRegistration")]
        public async Task<StaffRegistrationDto?> Get(int StaffRegistrationId)
        {
            var result = await _StaffRegistrationService.GetById(StaffRegistrationId);
            return result?.ToStaffRegistrationDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] StaffRegistrationDto requestDto)
        {
            var StaffRegistrationModel = requestDto.ToStaffRegistrationModel();
            return await _StaffRegistrationService.CreateStaffRegistration(StaffRegistrationModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] StaffRegistrationDto requestDto)
        {
            await _StaffRegistrationService.UpdateStaffRegistration(requestDto.ToStaffRegistrationModel());
            return Ok();
        }

        [HttpDelete, Route("{StaffRegistrationId}")]
        public async Task<IActionResult> Delete(int StaffRegistrationId)
        {
            await _StaffRegistrationService.DeleteStaffRegistration(StaffRegistrationId);
            return Ok();
        }
    }
}
