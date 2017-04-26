using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Course_proecto.Models
{
    class ContextWorkers : DbContext
    {
         public ContextWorkers(): base("DefaultConnection")
    {
    }
         public DbSet<Workers> Workerrs { get; set; }
    }
}

 
