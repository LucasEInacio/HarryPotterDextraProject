using HarryPotterProject.Domain.Characters.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Characters.Interfaces
{
    public interface ICharacterService
    {
        int Insert(CharacterRequest characterRequest);
        bool Update(CharacterRequest characterRequest);
        bool Delete(int id);
    }
}