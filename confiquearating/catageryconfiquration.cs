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
    internal class catageryconfiquration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("categery");
            builder.HasKey(ca => ca.id);
            builder.HasMany(ca => ca.manycourse)
                .WithOne(c => c.oneCategory)
                .HasForeignKey(c => c.catagoryid);

            builder.HasMany(ca => ca.manyCategories)
                .WithOne(ca => ca.parentcatefory)
                .HasForeignKey(ca => ca.parentid);
            builder.HasData(new Categories() { id = 1 , name = "Programming" , parentid = null},
                new Categories() { id = 2, name = "Design", parentid = null },
                new Categories() { id = 3, name = "Web Development", parentid = 1 },
                 new Categories() { id = 4, name = "ASP.NET Core", parentid = 2 },
                 new Categories() { id = 5, name = "UI/UX", parentid = 3 },
                 new Categories { id = 6, name = "Figma", parentid = 5 }

                );
        }
    }
}
