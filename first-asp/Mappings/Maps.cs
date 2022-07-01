using AutoMapper;
using first_asp.Data;
using first_asp.Models;

namespace first_asp.Mappings
{
    public class Maps : Profile
    {
        public Maps() 
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();        
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
