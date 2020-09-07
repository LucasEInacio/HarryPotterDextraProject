using HarryPotterProject.Domain.HarryPotterApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HarryPotterProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HarryPotterApiController : ControllerBase
    {
        private readonly IHarryPotterApi _repository;
        public HarryPotterApiController(IHarryPotterApi repository)
        {
            _repository = repository;
        }

        [HttpGet("houses")]
        public async Task<IActionResult> GetHouses()
        {
            return Ok(await _repository.GetHousesString());
        }
    }
}