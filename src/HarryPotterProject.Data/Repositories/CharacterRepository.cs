using HarryPotterProject.Data.EFConfiguration;
using HarryPotterProject.Domain.Characters.Dtos;
using HarryPotterProject.Domain.Characters.Entities;
using HarryPotterProject.Domain.Characters.Interfaces;
using System.Linq;

namespace HarryPotterProject.Data.Repositories
{
    public class CharacterRepository : RepositoryBase<Character, CharacterFilter>, ICharacterRepository
    {
        public CharacterRepository(HarryPotterContext context) : base(context)
        {
        }

        public override IQueryable<Character> GetAll(CharacterFilter filter)
        {
            var query = DbSet.AsQueryable();
            if (!string.IsNullOrEmpty(filter.House))
                query = query.Where(x => x.House == filter.House);

            if (!string.IsNullOrEmpty(filter.Name))
                query = query.Where(x => x.Name.Contains(filter.Name));

            return query;
        }
    }
}