using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GEE.DataAccess
{
    public class MyDataAccess<T> : IMyDataAccess<T> where T : class
    {
        public MyDataAccess()
        {
            DbContext = new GEEDbContext();
            if (DbContext == null)
            {
                throw new ArgumentNullException("Null DbContext");
            }
            DbSet = DbContext.Set<T>();
        }

        protected DbContext DbContext { get; set; }

        protected DbSet<T> DbSet { get; set; }

        public virtual List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual List<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = DbSet.Include(includes[0]);
            foreach (var include in includes.Skip(1))
            {
                query = query.Include(include);
            }
            return query.ToList();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return DbSet.ToListAsync();
        }

        public virtual Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = DbSet.Include(includes[0]);
            foreach (var include in includes.Skip(1))
            {
                query = query.Include(include);
            }
            return query.ToListAsync();
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual T Save(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
            DbContext.SaveChanges();
            return entity;
        }

        public virtual async Task<T> SaveAsync(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public virtual T Update(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
            DbContext.SaveChanges();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
                if (entity == null) return; // not found; assume already deleted.
                DbSet.Remove(entity);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
                if (entity == null) return; // not found; assume already deleted.
                DbSet.Remove(entity);
            }
        }

        public virtual List<T> RunSqlQuery(string query, params DbParameter[] parameters)
        {
            return DbSet.SqlQuery(query, parameters).ToList();
        }

        public virtual async Task<List<T>> RunSqlQueryAsync(string query, params DbParameter[] parameters)
        {
            return await DbSet.SqlQuery(query, parameters).ToListAsync();
        }
    }
}