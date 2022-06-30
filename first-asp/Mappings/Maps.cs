using AutoMapper;
using first_asp.Data;
using first_asp.Models;

namespace first_asp.Mappings
{
    public class Maps : Profile
    {
        public Maps() 
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();        
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
