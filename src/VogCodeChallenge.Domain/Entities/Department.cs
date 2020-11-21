using System;
using System.Collections.Generic;

namespace VogCodeChallenge.Domain.Entities
{
    public class Department
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public ICollection<Employee> Employees { get; private set; } = new List<Employee>();

        //Constructor for EF initialization
        protected Department()
        {

        }

        public Department(string name, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

    }
}
