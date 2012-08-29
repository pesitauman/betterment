using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
