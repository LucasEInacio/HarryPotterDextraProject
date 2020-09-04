using HarryPotterProject.Data.EFConfiguration;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.Characters.Interfaces;

namespace HarryPotterProject.Data.Repositories
{
    public class CharacterRepository : RepositoryBase<Character>, ICharacterRepository
    {
        public CharacterRepository(HarryPotterContext context) : base(context)
        {
        }
    }
}