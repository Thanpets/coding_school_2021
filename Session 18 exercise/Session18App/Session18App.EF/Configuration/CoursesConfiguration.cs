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
    public class CoursesConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(course => course.Id);
            builder.Property(course => course.Id).ValueGeneratedOnAdd();

            builder.Property(course => course.Title).HasMaxLength(150).IsRequired(true);
            builder.Property(course => course.Category).HasMaxLength(200).IsRequired(true);
            
        }
    }
}
