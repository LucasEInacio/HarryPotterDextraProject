using HarryPotterProject.Domain.Commom.Interfaces;

namespace HarryPotterProject.Domain.Characters.Entities
{
    public class Character : BaseEntity
    {
        public Character()
        {
        }
        public Character(int id, string name, string role, string school, string house, string patronus)
        {
            Id = id;
            Name = name;
            Role = role;
            School = school;
            House = house;
            Patronus = patronus;
        }

        public string Name { get; set; }
        public string Role { get; set; }
        public string School { get; set; }
        public string House { get; set; }
        public string Patronus { get; set; }
    }
}
