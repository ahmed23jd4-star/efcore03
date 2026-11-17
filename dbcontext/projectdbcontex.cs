using efcore03.confiquearating;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore03.dbcontext
{
    internal class projectdbcontex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=OnlineLearningDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new catageryconfiquration());
            modelBuilder.ApplyConfiguration(new courseconfiquration());
            modelBuilder.ApplyConfiguration(new enrollmentconfiquering());
            modelBuilder.ApplyConfiguration(new instructerconfiquration());
            modelBuilder.ApplyConfiguration(new studentconfqueration());

        }
    }
}
