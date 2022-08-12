﻿using EmployeePlayGround.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePlayGround.Infrastructure.EntityConfiguractions
{
    internal class EmployeeEntityTypeConfiguraction : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.Property(e => e.Email).HasMaxLength(100);

            builder.Property(e => e.Name).HasMaxLength(100);

            builder.Property(e => e.Salary).HasColumnType("decimal(12, 2)");

            builder.HasOne(d => d.Department)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(d => d.DepartmentId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Employee_Department");
        }
    }
}
