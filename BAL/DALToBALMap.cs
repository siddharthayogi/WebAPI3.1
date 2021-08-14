using AutoMapper;
using BAL.Core.Models;
using DAL.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL
{
    public class DALToBALMap: Profile
    {
        public DALToBALMap()
        {
            //Way 1
            CreateMap<Department, DepartmentViewModel>()
                  .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.DeptId))
                 .ForMember(dest => dest.DeptName, opt => opt.MapFrom(src => src.DeptName));

            //Way 2
            CreateMap<Employee, EmployeeViewModel>();
        }
    }
}
