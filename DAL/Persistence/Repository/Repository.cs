using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DAL.Core.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DAL.Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        //internal DbSet<T> _dbSet;
        //public readonly ILogger _logger;

        public Repository(AppDbContext context)//, ILogger logger)
        {
            _context = context;
            //_dbSet = context.Set<T>();
            //_logger = logger;
        }

        public virtual Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }
        public virtual Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }
        public virtual  Task<bool> Insert(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entity)
        {
            _context.Set<T>().AddRange(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _context.Set<T>().RemoveRange(entity);
        }
    }
}
