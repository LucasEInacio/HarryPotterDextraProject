using HarryPotterProject.Data.EFConfiguration;
using HarryPotterProject.Domain.Commom.Interfaces;
using System;

namespace HarryPotterProject.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HarryPotterContext _context;
        public UnitOfWork(HarryPotterContext context)
        {
            _context = context;
        }
        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
