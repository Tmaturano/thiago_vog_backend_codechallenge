using System.Collections.Generic;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Infra.Data.Context;

namespace VogCodeChallenge.Infra.Data.Extensions
{
    public static class VogContextExtension
    {
        public static void EnsureSeedDataForContext(this VogContext context)
        {
            context.Employees.RemoveRange(context.Employees);
            context.Departments.RemoveRange(context.Departments);

            var employees = new List<Employee>();
            var departments = new List<Department>();

            var department = new Department("Development", "Address 1");
            var employee = new Employee("Thiago", "Maturana", "Software Developer", "thiago@test.com");
            employees.Add(employee);
            department.AddEmployee(employee);

            employee = new Employee("Thiago 2", "Maturana 2", "Software Developer II", "thiago@test.com");
            employees.Add(employee);
            department.AddEmployee(employee);

            employee = new Employee("Thiago 3", "Maturana 3", "Software Developer III", "thiago@test.com");
            employees.Add(employee);
            department.AddEmployee(employee);

            departments.Add(department);

            department = new Department("IT", "Address 2");
            employee = new Employee("Thiago 4", "Maturana 4", "Computer Maintenance", "thiago@test.com");
            employees.Add(employee);
            department.AddEmployee(employee);

            departments.Add(department);

            context.Employees.AddRange(employees);
            context.Departments.AddRange(departments);
            context.SaveChanges();
        }
    }
}
