using HarryPotterProject.Domain.HarryPotterApi.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace HarryPotterProject.Data.APIs
{
    public class HarryPotterApi : IHarryPotterApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        public HarryPotterApi(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient(_configuration.GetSection("Services:HarryPotterApi").Key);
        }

        public async Task<string> GetHouses()
        {
            return await _httpClient.GetStringAsync("houses?key=$2a$10$tF87pZ7sPMMAYp0Ow/t72eAColXoF9qis/T.iMFR.dQSt/xqHiHWO");
        }
    }
}