using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoAspNet.Data
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _DbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task Save()
        {
            await _DbContext.SaveChangesAsync();
        }
    }
}
