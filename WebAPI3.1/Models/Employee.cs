using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI3._1.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDob { get; set; }
        public string EmpGender { get; set; }
        public string EmpEmail { get; set; }
        public string EmpMobile { get; set; }
        public decimal EmpSalary { get; set; }
        public string EmpAddress { get; set; }
        public string Department { get; set; }
    }
}
