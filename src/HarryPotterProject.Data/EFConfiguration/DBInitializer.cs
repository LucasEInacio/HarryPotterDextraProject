using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Data.EFConfiguration
{
    public static class DBInitializer
    {
        public static void Initialize(HarryPotterContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
