using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties.Conteiners
{
    class unemployedConteiner<T>
    where T : Information
    {
        public List<T> unemployed_people { get; set; }
        public int unemployed_people_amount { get; set; }

        public unemployedConteiner()
        {
            unemployed_people = new List<T>();
        }
    }
}
