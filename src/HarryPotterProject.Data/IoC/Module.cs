using HarryPotterProject.Data.Repositories;
using HarryPotterProject.Data.UoW;
using HarryPotterProject.Domain.Characters.Interfaces;
using HarryPotterProject.Domain.Commom.Interfaces;
using System;
using System.Collections.Generic;

namespace HarryPotterProject.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            return new Dictionary<Type, Type>
            {
                { typeof(ICharacterRepository), typeof(CharacterRepository)},
                { typeof(IUnitOfWork), typeof(UnitOfWork)}

            };
        }
    }
}
