using AutoMapper;
using BAL.Core.Models;
using DAL.Core.Domain;

namespace BAL
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //Way 1
            CreateMap<DepartmentViewModel, Department>()
                  .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.DeptId))
                 .ForMember(dest => dest.DeptName, opt => opt.MapFrom(src => src.DeptName)).ReverseMap();

            //Way 2
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
        }
    }
}
