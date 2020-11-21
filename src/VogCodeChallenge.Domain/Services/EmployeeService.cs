using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Domain.Interfaces;

namespace VogCodeChallenge.Domain.Services
{
    public class EmployeeService: ServiceBase<Employee>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository employeeRepository): base(employeeRepository)
        {
        }
    }
}
