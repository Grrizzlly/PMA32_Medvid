using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using course_last.Enteties;
namespace course_last.Enteties
{
   public class DBContext : DbContext
    {
       public DBContext(string connectionString)
       {
           Database.Connection.ConnectionString = connectionString;
       }
      public  DbSet<Information> Info { get; set; }
       public DbSet<unemployed> unemployers { get; set; }
       public DbSet<Full_employment> Full_employmet_Jobs { get; set; }
       public DbSet<underemployment> underemploymet_Jobs { get; set; }

    }
}
