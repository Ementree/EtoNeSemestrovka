using Blog.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class Repository<TEntity, TContext> : IRepository<TEntity> 
        where TEntity : class
        where TContext : ApplicationDbContext
    {
        private readonly TContext _dbContext;

        public Repository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public async Task<TEntity> Get(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Add(TEntity entity)
        {
           await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
