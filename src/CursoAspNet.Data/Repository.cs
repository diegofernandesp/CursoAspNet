using CursoAspNet.Domain;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDbContext _DbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public TEntity GetById(int id)
        {
            return _DbContext.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public void Save(TEntity entity)
        {
            _DbContext.Set<TEntity>().Add(entity);
        }
    }
}
