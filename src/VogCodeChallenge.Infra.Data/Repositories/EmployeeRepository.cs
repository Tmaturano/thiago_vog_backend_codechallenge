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
    }
}
