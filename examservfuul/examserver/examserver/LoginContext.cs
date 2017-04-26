using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace examserver
{
    public class LoginContext: DbContext
    {
        public LoginContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Loginclass> Logins { get; set; }
        
    }
}