namespace HarryPotterProject.Domain.HarryPotterApi.Dtos
{
    public class HouseResponse
    {
        public HouseResponse(string id, string name)
        {
            _id = id;
            Name = name;
        }

        public string _id { get; set; }
        public string Name { get; set; }
    }
}