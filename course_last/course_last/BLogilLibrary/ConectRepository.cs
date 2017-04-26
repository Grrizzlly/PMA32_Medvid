using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using course_last.Enteties;
namespace course_last.BLogilLibrary
{
   public abstract class  ConectRepository
    {
     //protected readonly string _connectionString;
     protected readonly string context;
        public ConectRepository()
        {
            context = ConfigurationManager.ConnectionStrings[0].ConnectionString;
           
        }
    }
}
