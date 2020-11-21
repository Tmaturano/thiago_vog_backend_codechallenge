using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Domain.Interfaces;
using VogCodeChallenge.Infra.Data.Context;

namespace VogCodeChallenge.Infra.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(VogContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Employee>> GetAll()
        {
            return await DbSet.Include(d => d.Department).AsNoTracking().ToListAsync();            
        }
    }
}
