using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotterProject.Domain.Characters.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HarryPotterProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepository;
        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_characterRepository.GetAll());
        }
    }
}
