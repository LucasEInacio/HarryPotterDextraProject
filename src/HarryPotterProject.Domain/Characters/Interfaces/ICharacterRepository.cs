using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.Commom.Interfaces;

namespace HarryPotterProject.Domain.Characters.Interfaces
{
    public interface ICharacterRepository: IRepository<Character, CharacterFilter>
    {
    }
}
