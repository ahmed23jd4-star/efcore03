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
    public class courseconfiquration : IEntityTypeConfiguration<course>
    {
        public void Configure(EntityTypeBuilder<course> builder)
        {
            builder.ToTable("courses");
            builder.HasKey(c => c.id);
            builder.Property(c => c.title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.price).HasColumnType("decimal(10,2)");
            builder.HasOne(c => c.oneInstructors)
                .WithMany(i => i.coursess)
                .HasForeignKey(c => c.instrucrorid);
            builder.HasData(new course (){
                id = 1,
                title = "C# Fundamentals",
                price = 49.99m,
                level = levelcouse.Beginner,
                flag = true,
                date = new DateTime(2024, 1, 10),
                instrucrorid = 1,
                catagoryid = 1
            },
            new course ()
            {
                id = 2,
                title = "HTML & CSS Basics",
                price = 29.99m,
                level = levelcouse.Beginner,
                flag = true,
                date = new DateTime(2024, 2, 5),
                instrucrorid = 2,
                catagoryid = 3
            },
            new course ()
            {
                id = 3,
                title = "ASP.NET Core Web API",
                price = 79.99m,
                level = levelcouse.Intermediate,
                flag = true,
                date = new DateTime(2024, 4, 20),
                instrucrorid = 1,
                catagoryid = 4
            },
            new course()
            {
                id = 4,
                title = "Figma for Beginners",
                price = 39.99m,
                level = levelcouse.Beginner,
                flag = false,
                date = null,
                instrucrorid = 3,
                catagoryid = 6
            },
            new course()
            {
                id = 5,
                title = "Advanced UI/UX Patterns",
                price = 89.99m,
                level = levelcouse.Advanced,
                flag = false,
                date = null,
                instrucrorid = 2,
                catagoryid = 5
            },
            new course()
            {
                id = 6,
                title = "EF Core Deep Dive",
                price = 99.99m,
                level = levelcouse.Advanced,
                flag = true,
                date = new DateTime(2024, 6, 1),
                instrucrorid = 3,
                catagoryid = 4
            }
          );

        }
    }
}
