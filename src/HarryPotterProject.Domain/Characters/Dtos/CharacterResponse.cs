namespace HarryPotterProject.Domain.Characters.Dtos
{
    public class CharacterResponse
    {
        public CharacterResponse(int id, string name, string role, string school, string house, string houseName, string patronus)
        {
            Id = id;
            Name = name;
            Role = role;
            School = school;
            House = house;
            HouseName = houseName;
            Patronus = patronus;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }
        public string School { get; private set; }
        public string House { get; private set; }
        public string HouseName { get; private set; }
        public string Patronus { get; private set; }
    }
}
