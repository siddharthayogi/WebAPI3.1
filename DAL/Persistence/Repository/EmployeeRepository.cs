using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Core.Domain;
using DAL.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace DAL.Persistence.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployee
    {
        Task<IEnumerable<Employee>> Get(int pageSize, int pageIndex, string sortColumn, string sortOrder, string searchString)
        {
            List<Employee> employees = new List<Employee>();
            pageIndex += 1;
            var employee = (dynamic)null;
            return employee.ToList();
        }
    }
}
