using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.Characters.Interfaces;
using HarryPotterProject.Domain.Commom;
using HarryPotterProject.Domain.Commom.Interfaces;
using HarryPotterProject.Domain.HarryPotterApi.Dtos;
using HarryPotterProject.Domain.HarryPotterApi.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterProject.Domain.Characters.Services
{
    public class CharacterService : ServiceBase, ICharacterService
    {
        private readonly ICharacterRepository _repository;
        private readonly IHarryPotterApi _harryPotterApi;
        private readonly IUnitOfWork _unitOfWork;
        public CharacterService(ICharacterRepository repository, IUnitOfWork unitOfWork, IHarryPotterApi harryPotterApi)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _harryPotterApi = harryPotterApi;
        }

        public async Task<IEnumerable<CharacterResponse>> GetAll(CharacterFilter filter)
        {
            var houses = await _harryPotterApi.GetHouses();
            var characters = _repository.GetAll(filter);

            return MountResponse(characters, houses);
        }

        public int Insert(CharacterRequest characterRequest)
        {
            if (!ValidateRequest(characterRequest))
                return characterRequest.Id;
            
            var character = new Character(0, characterRequest.Name, characterRequest.Role, characterRequest.School, characterRequest.House, characterRequest.Patronus);

            _repository.Insert(character);

            _unitOfWork.Commit();

            return character.Id;
        }

        public bool Update(CharacterRequest characterRequest)
        {
            if (!ValidateRequest(characterRequest))
                return false;

            var character = new Character(characterRequest.Id, characterRequest.Name, characterRequest.Role, characterRequest.School, characterRequest.House, characterRequest.Patronus);

            _repository.Update(character);

            return _unitOfWork.Commit();
        }

        public bool Delete(int id)
        {
            _repository.Delete(id);

            return _unitOfWork.Commit();
        }

        private List<CharacterResponse> MountResponse(IQueryable<Character> characters, IEnumerable<HouseResponse> houses)
        {
            var response = new List<CharacterResponse>();

            foreach (var character in characters)
            {
                var houseName = houses.FirstOrDefault(a => a._id == character.House)?.Name;
                response.Add(new CharacterResponse(character.Id, character.Name, character.Role, character.School, character.House, houseName, character.Patronus));
            }

            return response;
        }
    }
}
