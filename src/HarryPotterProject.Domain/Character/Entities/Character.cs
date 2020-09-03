﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Character.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string School { get; set; }
        public string House { get; set; }
        public string Patronus { get; set; }
    }
}