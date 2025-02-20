using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF01_ITI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF01_ITI.Configuration
{
    class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Name).IsRequired();
            I.Property(I => I.Address).HasDefaultValue("cairo");
            I.Property(I => I.Salary).HasColumnType("money");
        }
    }
}
