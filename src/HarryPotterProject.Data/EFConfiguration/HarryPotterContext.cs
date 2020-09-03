using HarryPotterProject.Data.EFConfiguration.Mapping;
using HarryPotterProject.Domain.Character.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
