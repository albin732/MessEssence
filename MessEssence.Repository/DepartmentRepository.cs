using MessEssence.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessEssence.Repository
{

    public class DepartmentRepository : BaseRepository<Department>
    {
        public DepartmentRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

    }
}
