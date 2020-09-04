using HarryPotterProject.Data.EFConfiguration.Mapping;
using HarryPotterProject.Domain.Characters.Entities;
using Microsoft.EntityFrameworkCore;

namespace HarryPotterProject.Data.EFConfiguration
{
    public class HarryPotterContext: DbContext
    {
        public HarryPotterContext(DbContextOptions<HarryPotterContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Character");

            modelBuilder.ApplyConfiguration(new CharacterMap());
        }
    }
}
