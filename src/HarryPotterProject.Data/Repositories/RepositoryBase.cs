using HarryPotterProject.Data.EFConfiguration;
using HarryPotterProject.Domain.Commom.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HarryPotterProject.Data.Repositories
{
    public class RepositoryBase<TEntity, TFilter> : IRepository<TEntity, TFilter> 
        where TEntity : BaseEntity
        where TFilter : class
    {
        protected readonly HarryPotterContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public RepositoryBase(HarryPotterContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Delete(int id)
        {
            Db.Remove(DbSet.Find(id));
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<TEntity> GetAll(TFilter filter)
        {
            return DbSet;
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Insert(TEntity obj)
        {
            Db.Add(obj);
        }

        public int Save()
        {
            return Db.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            Db.Update(obj);
        }
    }
}
