using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DbApp.Models
{
    public class MobileContext : DbContext
    {
        public MobileContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Firm> Firms { get; set; }
    }
}
