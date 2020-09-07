﻿using HarryPotterProject.Domain.Characters.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HarryPotterProject.Domain.Characters.Interfaces
{
    public interface ICharacterService
    {
        int Insert(CharacterRequest characterRequest);
        bool Update(CharacterRequest characterRequest);
        bool Delete(int id);
        Task<IEnumerable<CharacterResponse>> GetAll(CharacterFilter filter);
    }
}