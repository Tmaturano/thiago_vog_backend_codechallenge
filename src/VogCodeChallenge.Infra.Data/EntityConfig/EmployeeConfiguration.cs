using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VogCodeChallenge.Domain.Entities;

namespace VogCodeChallenge.Infra.Data.EntityConfig
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.FirstName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(e => e.LastName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(e => e.JobTitle).HasColumnType("varchar(100)").IsRequired();
            builder.Property(e => e.MailingAddress).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
