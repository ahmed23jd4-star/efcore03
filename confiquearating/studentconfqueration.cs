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
    public class studentconfqueration : IEntityTypeConfiguration<student>
    {
        public void Configure(EntityTypeBuilder<student> builder)
        {
            builder.ToTable("stuents");
            builder.HasKey(s => s.id);
            
        }
    }
}
