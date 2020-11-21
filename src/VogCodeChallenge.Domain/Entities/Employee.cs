using System;

namespace VogCodeChallenge.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string JobTitle { get; private set; }
        public string MailingAddress { get; private set; }
        public Department Department { get; set; }

        protected Employee()
        {
        }

        public Employee(string firstName, string lastName, string jobTitle, string mailingAddress)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            MailingAddress = mailingAddress;
        }
    }
}
