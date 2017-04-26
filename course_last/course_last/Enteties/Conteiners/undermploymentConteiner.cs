using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties.Conteiners
{
    class undermploymentConteiner<T>
    where T : underemployment
    {
        public List<T> underemploymentJobs { get; set; }
        public int Full_empGObsCount { get; set; }

        public undermploymentConteiner()
        {
            underemploymentJobs = new List<T>();
        }
    }
}
