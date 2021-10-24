using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class JoinTable
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DateOfJoining { get; set; }
        
    }
}
