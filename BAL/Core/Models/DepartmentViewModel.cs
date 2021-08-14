using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BAL.Core.Models
{
    public class DepartmentViewModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<DepartmentViewModel> Departments { get; set; }
    }
}
