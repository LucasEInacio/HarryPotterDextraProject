using System.Threading.Tasks;

namespace HarryPotterProject.Domain.HarryPotterApi.Interfaces
{
    public interface IHarryPotterApi
    {
        Task<string> GetHouses();
    }
}
