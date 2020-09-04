using HarryPotterProject.Domain.Commom.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public bool Commit()
        {
            return 
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
