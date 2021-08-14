using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Core.Domain
{
    public class Employee
    {
        public int EmpId { get; set; }


        [StringLength(100)]
        public string EmpName { get; set; }


        [StringLength(10)]
        public string EmpDob { get; set; }

        [StringLength(1)]
        public string EmpGender { get; set; }
        public string EmpEmail { get; set; }


        [StringLength(10)]
        public string EmpMobile { get; set; }
        public decimal EmpSalary { get; set; }
        public string EmpAddress { get; set; }
        public string Department { get; set; }
    }
}
