using HarryPotterProject.Domain.Characters.Interfaces;
using HarryPotterProject.Domain.Characters.Services;
using System;
using System.Collections.Generic;

namespace HarryPotterProject.Domain.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            return new Dictionary<Type, Type>
            {
                { typeof(ICharacterService), typeof(CharacterService)}
            };
        }
    }
}
