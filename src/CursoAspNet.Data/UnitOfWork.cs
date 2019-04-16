using CursoAspNet.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoAspNet.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _DbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task Commit()
        {
            await _DbContext.SaveChangesAsync();
        }
    }
}
