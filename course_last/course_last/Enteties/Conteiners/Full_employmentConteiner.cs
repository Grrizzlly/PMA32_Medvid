using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties.Conteiners
{
    class Full_employmentConteiner<T>
    where T : Full_employment
    {
        public List<T> Full_employmentJobs { get; set; }
        public int Full_empGObsCount { get; set; }

        public Full_employmentConteiner()
        {
            Full_employmentJobs = new List<T>();
        }
    }
}
