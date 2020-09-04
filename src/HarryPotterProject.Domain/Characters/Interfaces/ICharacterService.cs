using HarryPotterProject.Domain.Characters.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Characters.Interfaces
{
    public interface ICharacterService
    {
        int Insert(CharacterRequest characterRequest);
    }
}
