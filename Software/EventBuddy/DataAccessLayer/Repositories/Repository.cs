﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public abstract class Repository<T> : IDisposable where T : class
    {
        protected EventBuddyModel Context { get; set; }
        public DbSet<T> Entities { get; set; }

        public Repository(EventBuddyModel context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            var query = from e in Entities select e;
            return query;
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public virtual int Add(T entity, bool saveChanges = true)
        {
            Entities.Add(entity);
            return saveChanges ? SaveChanges() : 0;
        }

        public abstract int Update(T entity, bool saveChanges = true);

        public virtual int Remove(T entity, bool saveChanges = true)
        {
            Entities.Attach(entity);
            Entities.Remove(entity);
            return saveChanges ? SaveChanges() : 0;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}