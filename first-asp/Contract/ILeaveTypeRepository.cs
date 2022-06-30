using first_asp.Data;
using System.Collections.Generic;

namespace first_asp.Contract
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
