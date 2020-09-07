using HarryPotterProject.Domain.HarryPotterApi.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HarryPotterProject.Domain.HarryPotterApi.Interfaces
{
    public interface IHarryPotterApi
    {
        Task<string> GetHousesString();
        Task<IEnumerable<HouseResponse>> GetHouses();
        Task<string> GetHouseById(string id);
    }
}
