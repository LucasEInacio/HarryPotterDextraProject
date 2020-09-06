using HarryPotterProject.Data.APIs;
using HarryPotterProject.Data.Repositories;
using HarryPotterProject.Data.UoW;
using HarryPotterProject.Domain.Characters.Interfaces;
using HarryPotterProject.Domain.Commom.Interfaces;
using HarryPotterProject.Domain.HarryPotterApi.Interfaces;
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
                { typeof(IUnitOfWork), typeof(UnitOfWork)},
                { typeof(IHarryPotterApi), typeof(HarryPotterApi)}

            };
        }
    }
}
