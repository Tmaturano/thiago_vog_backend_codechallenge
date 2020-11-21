using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Domain.Interfaces;
using VogCodeChallenge.Infra.Data.Context;

namespace VogCodeChallenge.Infra.Data.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(VogContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Department>> GetEmployeesByDepartmentIdAsync(Guid departmentId)
        {
            return await DbSet.Where(d => d.Id == departmentId).ToListAsync();
        }
    }
}
