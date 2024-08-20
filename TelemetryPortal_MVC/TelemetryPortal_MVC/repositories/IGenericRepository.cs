using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TelemetryPortal_MVC.repositories
{
    public interface IGenericRepository<P> where P : class
    {
        P GetByID(int id);

        IEnumerable<P> GetAll();

        IEnumerable<P> Find(Expression<Func<P, bool>> expression);

        void Add(P entity);

        void AddRange(IEnumerable<P> entities);

        void Remove(P entity);

        void RemoveRange(IEnumerable<P> entities);

    }
}
