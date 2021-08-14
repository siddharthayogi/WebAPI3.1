using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Core.Repository;

namespace DAL.Core
{
    public interface IUnitOfWork
    {
        IDepartment Departments { get;  }
        IEmployee Employees { get; }
        //Task CompleteAsync();
    }
}
