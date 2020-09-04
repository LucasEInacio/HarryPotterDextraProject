using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
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
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterRepository characterRepository, ICharacterService characterService)
        {
            _characterRepository = characterRepository;
            _characterService = characterService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_characterRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_characterRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Insert(CharacterRequest characterRequest)
        {
            return Ok(_characterService.Insert(characterRequest));
        }

        [HttpPut]
        public IActionResult Update(CharacterRequest characterRequest)
        {
            return Ok(_characterService.Insert(characterRequest));
        }
    }
}
