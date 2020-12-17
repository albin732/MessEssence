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
        public string EmployeeName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
