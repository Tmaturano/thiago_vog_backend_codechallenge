using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Entities;

namespace VogCodeChallenge.Domain.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<IEnumerable<Department>> GetEmployeesByDepartmentIdAsync(Guid departmentId);
    }
}
