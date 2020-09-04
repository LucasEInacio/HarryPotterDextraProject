using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.Characters.Interfaces;

namespace HarryPotterProject.Domain.Characters.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _repository;
        public CharacterService(ICharacterRepository repository)
        {
            _repository = repository;
        }

        public int Insert(CharacterRequest characterRequest)
        {
            var character = new Character(characterRequest.Name, characterRequest.Role, characterRequest.School, characterRequest.House, characterRequest.Patronus);

            _repository.Insert(character);

            return character.Id;
        }
    }
}
