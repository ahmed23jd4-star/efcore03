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
    public class enrollmentconfiquering : IEntityTypeConfiguration<enrolment>
    {
        public void Configure(EntityTypeBuilder<enrolment> builder)
        {
            builder.ToTable("enrolment");
            builder.HasKey(e => new { e.studentid, e.courseid});
            builder.HasOne(e => e.onestudent)
                .WithMany(s => s.manyenrollment)
                .HasForeignKey(e => e.studentid);
            builder.HasOne(e => e.onecourse)
                .WithMany(c => c.manyenrolment)
                .HasForeignKey(e => e.courseid);

            builder.Property(e => e.Finalgrade).HasPrecision(5, 2);


        }
    }
}
