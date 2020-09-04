using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotterProject.Domain.Commom.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        int Save();
    }
}
