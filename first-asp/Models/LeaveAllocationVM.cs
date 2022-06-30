using System;
using System.ComponentModel.DataAnnotations;

namespace first_asp.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
      
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
      
        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
