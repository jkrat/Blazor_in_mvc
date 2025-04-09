using Blazor_in_mvc.Models;
using Blazor_in_mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_in_mvc.Controllers
{
    public class ApiController : ControllerBase
    {
        private readonly ITestService _testService;

        public ApiController(ITestService testService)
        {
            _testService = testService;
        }

        [Route("api/[action]/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> GetData(int id)
        {
            await Task.Delay(1000); // Simulate some async work

            VehicleViewModel model = _testService.GetData(id);

            return Ok(model);
        }
    }
}
