using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HarryPotterProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ApiBase
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterRepository characterRepository, ICharacterService characterService) : base(characterService)
        {
            _characterRepository = characterRepository;
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] CharacterFilter filter)
        {
            return Ok(await _characterService.GetAll(filter));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_characterRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Insert([FromBody]CharacterRequest characterRequest)
        {
            return Response(_characterService.Insert(characterRequest));
        }

        [HttpPut]
        public IActionResult Update([FromBody] CharacterRequest characterRequest)
        {
            return Response(_characterService.Update(characterRequest));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_characterService.Delete(id));
        }
    }
}
