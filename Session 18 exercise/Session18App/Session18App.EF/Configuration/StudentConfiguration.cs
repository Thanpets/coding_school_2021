using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session18App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session18App.EF.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(student => student.Id);
            builder.Property(student => student.Id).ValueGeneratedOnAdd();

            builder.Property(student => student.Name).HasMaxLength(100).IsRequired(true);
            builder.Property(student => student.Surname).HasMaxLength(100).IsRequired(true);
            builder.Property(student => student.Adress).HasMaxLength(500).IsRequired(false);
        }
    }
}