using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Characters.Entities
{
    public class Character
    {
        public Character(string name, string role, string school, string house, string patronus)
        {
            Name = name;
            Role = role;
            School = school;
            House = house;
            Patronus = patronus;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string School { get; set; }
        public string House { get; set; }
        public string Patronus { get; set; }
    }
}
