using first_asp.Contract;
using first_asp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace first_asp.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);   
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var leavAllocation = _db.LeaveAllocations.ToList();
            return leavAllocation;
        }

        public LeaveAllocation FindById(int id)
        {
            var leaveAllocatios = _db.LeaveAllocations.Find(id);
            return leaveAllocatios;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
