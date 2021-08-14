using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Core.Domain
{
    public class Department
    {
        public int DeptId { get; set; }

        [StringLength(50)]
        public string DeptName { get; set; }
    }
}
