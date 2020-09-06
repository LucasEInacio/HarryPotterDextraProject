using System;
using System.Linq;

namespace HarryPotterProject.Domain.Commom.Interfaces
{
    public interface IRepository<TEntity, TFilter> : IDisposable 
        where TEntity : BaseEntity
        where TFilter : class
    {
        IQueryable<TEntity> GetAll(TFilter filter);
        TEntity GetById(int id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        int Save();
    }
}