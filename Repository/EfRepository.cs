using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webdot.Data;

namespace webdot.Repository
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;

        public EfRepository(DatabaseContext context)
        {
            _context = context;
        }

        public T add(T model)
        {
            T result = new T();
            _context.Add(model);
            _context.SaveChanges();
            result = model;
            return result;
        }

        public List<T> getAll()
        {
            List<T> result = _context.Set<T>().ToList();
            return result;
        }

        public T getById(int id)
        {
            T result = new T();
            result = _context.Set<T>().Find(id);
            return result;
        }

        public T remove(int id)
        {
            T result = new T();
            T item = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
            result = item;
            return result;
        }

        public T update(T model, int id)
        {
            T result = new T();
            T item = _context.Set<T>().Find(id);
            _context.Set<T>().Update(model);
            _context.SaveChanges();
            result = model;
            return result;
        }
    }
}