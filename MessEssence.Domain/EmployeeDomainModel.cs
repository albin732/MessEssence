using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessEssence.Domain
{
    public class EmployeeDomainModel
    {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }


        public string DepartmentName { get; set; }
    }
}
