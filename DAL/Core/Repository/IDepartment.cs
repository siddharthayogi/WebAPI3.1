using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Core.Domain;

namespace DAL.Core.Repository
{
    public interface IDepartment : IRepository<Department>
    {
        //Task<IEnumerable<Department>> Get(int pageSize, int pageIndex, double rowCount, string sortColumn, string sortOrder, string searchText);
    }
}
