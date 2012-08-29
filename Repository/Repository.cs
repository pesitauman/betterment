using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Data;
using System.Data;

namespace Repository
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly DataContext dataContext;
        public Repository()
        {
            dataContext = new DataContext();
        }

        public T GetById(object id)
        {
            return dataContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            dataContext.Set<T>().Add(entity);
            this.dataContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
            this.dataContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dataContext.Set<T>().Remove(entity);
            this.dataContext.SaveChanges();
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return dataContext.Set<T>();
            }
        }


    }
}
