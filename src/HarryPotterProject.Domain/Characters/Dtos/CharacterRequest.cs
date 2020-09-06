using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Characters.Dtos
{
    public class CharacterRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string School { get; set; }
        public string House { get; set; }
        public string Patronus { get; set; }
    }
}
