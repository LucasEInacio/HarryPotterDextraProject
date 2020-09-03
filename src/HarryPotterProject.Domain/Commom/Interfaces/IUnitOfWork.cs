using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterProject.Domain.Commom.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
