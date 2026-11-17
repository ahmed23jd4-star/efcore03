using efcore03.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore03.confiquearating
{
    public class instructerconfiquration : IEntityTypeConfiguration<Instructors>
    {
        public void Configure(EntityTypeBuilder<Instructors> builder)
        {
            builder.ToTable("instercors");
            builder.Property(i => i.fullname).IsRequired();
            builder.HasData(new Instructors() { id = 1, fullname = "Ahmed Hassan", datejoining = new DateTime(2022, 01, 15) },
            new Instructors() { id = 2, fullname = "Sara Ali", datejoining = new DateTime(2000, 01, 15) },
            new Instructors() { id = 3, fullname = "Omar Khaled", datejoining = new DateTime(1900, 01, 01) }
                );
        }
    }
}
