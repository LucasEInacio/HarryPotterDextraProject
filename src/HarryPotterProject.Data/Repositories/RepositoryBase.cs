using HarryPotterProject.Data.EFConfiguration;
using HarryPotterProject.Domain.Commom.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotterProject.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly HarryPotterContext Db;
        private readonly DbSet<TEntity> DbSet;
        public RepositoryBase(HarryPotterContext context)
        {
            Db = context;
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

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public void Insert(TEntity obj)
        {
            Db.Add(obj);
        }

        public int Save()
        {
            return Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Update(obj);
        }
    }
}
