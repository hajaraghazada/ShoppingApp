using Core.DataRepositories.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataRepositories.Concrete
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        protected readonly TContext _context;
        private DbSet<TEntity> _entities;

        public BaseRepository(TContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
           entity.IsActive=false;
            _entities.Update(entity);
            _context.SaveChanges();

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _entities.SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate).Where(p=>p.IsActive).ToList();
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
