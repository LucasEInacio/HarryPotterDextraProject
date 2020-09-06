using HarryPotterProject.Domain.HarryPotterApi.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterProject.Domain.HarryPotterApi.Interfaces
{
    public interface IHarryPotterApi
    {
        Task<string> GetHouses();
    }
}
