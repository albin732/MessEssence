using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessEssenceUI.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }


        public string DepartmentName { get; set; }
    }
}