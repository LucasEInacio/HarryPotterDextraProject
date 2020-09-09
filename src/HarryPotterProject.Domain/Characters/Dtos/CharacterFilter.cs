using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Characters.Dtos
{
    public class CharacterFilter
    {
        public CharacterFilter(string name, string house)
        {
            Name = name;
            House = house;
        }

        public string Name { get; set; }
        public string House { get; set; }
    }
}
