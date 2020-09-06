using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.Characters.Interfaces;
using HarryPotterProject.Domain.Commom.Interfaces;

namespace HarryPotterProject.Domain.Characters.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public CharacterService(ICharacterRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public int Insert(CharacterRequest characterRequest)
        {
            var character = new Character(0, characterRequest.Name, characterRequest.Role, characterRequest.School, characterRequest.House, characterRequest.Patronus);

            _repository.Insert(character);

            _unitOfWork.Commit();

            return character.Id;
        }

        public bool Update(CharacterRequest characterRequest)
        {
            var character = new Character(characterRequest.Id, characterRequest.Name, characterRequest.Role, characterRequest.School, characterRequest.House, characterRequest.Patronus);

            _repository.Update(character);
            
            return _unitOfWork.Commit();
        }

        public bool Delete(int id)
        {
            _repository.Delete(id);

            return _unitOfWork.Commit();
        }
    }
}
