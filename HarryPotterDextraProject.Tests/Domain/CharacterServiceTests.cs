using System;
using Xunit;
using NSubstitute;
using HarryPotterProject.Domain.Characters.Interfaces;
using HarryPotterProject.Domain.Characters.Services;
using HarryPotterProject.Domain.Commom.Interfaces;
using HarryPotterProject.Domain.HarryPotterApi.Interfaces;
using System.Collections.Generic;
using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.HarryPotterApi.Dtos;
using System.Linq;

namespace HarryPotterDextraProject.Domain.Tests
{
    public class CharacterServiceTests
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IHarryPotterApi _harryPotterApi;
        private readonly IUnitOfWork _unitOfWork;
        private readonly CharacterService _service;
        public CharacterServiceTests()
        {
            _characterRepository = Substitute.For<ICharacterRepository>();
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _harryPotterApi = Substitute.For<IHarryPotterApi>();

            _service = new CharacterService(_characterRepository, _unitOfWork, _harryPotterApi);
        }

        [Fact]
        public async void GetAllCharacters()
        {
            var filter = new CharacterFilter(null, null);
            _harryPotterApi.GetHouses().Returns(GetHouses());
            _characterRepository.GetAll(Arg.Is<CharacterFilter>(x => x.Name == filter.Name && x.House == filter.House)).Returns(GetCharacters());

            var result = await _service.GetAll(filter);

            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            await _harryPotterApi.Received().GetHouses();
            _characterRepository.Received().GetAll(Arg.Is<CharacterFilter>(x => string.IsNullOrEmpty(x.Name) && string.IsNullOrEmpty(x.House)));
        }

        [Fact]
        public async void GetCharacterByName()
        {
            var filter = new CharacterFilter("Harry", null);
            var characters = GetCharacters();
            var harry = characters.FirstOrDefault(x => x.Name == "Harry");

            _harryPotterApi.GetHouses().Returns(GetHouses());
            _characterRepository.GetAll(Arg.Is<CharacterFilter>(x => x.Name == filter.Name && x.House == filter.House)).Returns((new List<Character>() { harry }).AsQueryable());

            var result = await _service.GetAll(filter);

            var characterResponse = result.FirstOrDefault(x => x.Name == harry.Name);

            Assert.Equal(harry.Id, characterResponse.Id);
            Assert.Equal(harry.Name, characterResponse.Name);

            Assert.NotNull(result);
            Assert.Single(result);
            await _harryPotterApi.Received().GetHouses();
            _characterRepository.Received().GetAll(Arg.Is<CharacterFilter>(x => x.Name == filter.Name && x.House == filter.House));
        }

        [Fact]
        public void InsertCharacter()
        {
            var character = GetCharacterRequest();

            _characterRepository.Insert(Arg.Is<Character>(x => x.Id == character.Id && x.Name == character.Name));

            var result = _service.Insert(character);

            Assert.Equal(character.Id, result);
            _characterRepository.Received().Insert(Arg.Is<Character>(x => x.Id == character.Id && x.Name == character.Name));
        }

        [Fact]
        public void UpdateCharacter()
        {
            var character = GetCharacterRequest();

            _characterRepository.Update(Arg.Is<Character>(x => x.Id == character.Id && x.Name == character.Name));
            _unitOfWork.Commit().Returns(true);

            var result = _service.Update(character);

            Assert.True(result);
            _characterRepository.Received().Update(Arg.Is<Character>(x => x.Id == character.Id && x.Name == character.Name));
            _unitOfWork.Received().Commit();
        }

        [Fact]
        public void DeleteCharacter()
        {
            _characterRepository.Delete(Arg.Any<int>());
            _unitOfWork.Commit().Returns(true);

            var result = _service.Delete(1);

            Assert.True(result);
            _characterRepository.Received().Delete(Arg.Any<int>());
            _unitOfWork.Received().Commit();
        }

        private CharacterRequest GetCharacterRequest()
        {
            return new CharacterRequest(0, "Harry", "student", "Hogwarts", "3456fs3fsd43", "stag");
        }

        private IEnumerable<HouseResponse> GetHouses()
        {
            return new List<HouseResponse>()
            {
                new HouseResponse("3456fs3fsd43", "Gryfindor"),
                new HouseResponse("b234jbib34", "Slytherin")
            };
        }

        private IQueryable<Character> GetCharacters()
        {
            var characterList = new List<Character>()
            {
                new Character(1, "Harry", "Student", "Hogwarts", "3456fs3fsd43", "stag"),
                new Character(2, "Hermione", "Wizard", "Hogwarts", "b234jbib34", "Deer")
            };

            return characterList.AsQueryable();
        }
    }
}
