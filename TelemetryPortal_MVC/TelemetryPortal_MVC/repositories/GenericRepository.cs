using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TelemetryPortal_MVC.Data;

namespace TelemetryPortal_MVC.repositories
{
    public class GenericRepository<P> : IGenericRepository<P> where P : class
    {
        protected readonly TechtrendsContext _context;
        public GenericRepository(TechtrendsContext context)
        {
            _context = context;
        }

        public void Add(P entity)
        {
            _context.Set<P>().Add(entity);
        }

        public void AddRange(IEnumerable<P> entities)
        {
            _context.Set<P>().AddRange(entities);
        }

        public IEnumerable<P> Find(Expression<Func<P, bool>> expression)
        {
            return _context.Set<P>().Where(expression);
        }

        public IEnumerable<P> GetAll()
        {
            return _context.Set<P>().ToList();
        }

        public P GetByID(int id)
        {
            return _context.Set<P>().Find(id);
        }

        public void Remove(P entity)
        {
            _context.Set<P>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<P> entities)
        {
            _context.Set<P>().RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
