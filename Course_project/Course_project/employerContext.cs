using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Course_project
{
    class employerContext :DbContext
    {
        public employerContext(): base("DefaultConnection")
    {
 
    }
        public DbSet<unemployed> unemployed_workers { get; set; }
        public DbSet<Full_employment> full_employment_jobs { get; set; }
        public DbSet<underemployment> underemployment_jobs { get; set; }
        public DbSet<Information> Info { get; set; }
    }
}
