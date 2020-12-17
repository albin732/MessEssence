using MessEssence.Repository.Infrastructure.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessEssence.Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MessEssenceSQLDbEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new MessEssenceSQLDbEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
