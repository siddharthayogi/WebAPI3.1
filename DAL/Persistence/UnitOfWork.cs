using System;
using System.Collections.Generic;
using System.Text;
using DAL.Core;
using DAL.Core.Domain;
using DAL.Core.Repository;
using DAL.Persistence.Repository;

namespace DAL.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            //_context = new AppDbContext();
            //Departments = new DepartmentRepository(_context);
            //Employees = new EmployeeRepository(_context);
        }

        public IDepartment Departments { get; private set; }
        public IEmployee Employees { get; private set; }
    }
}
