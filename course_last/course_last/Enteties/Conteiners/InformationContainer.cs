using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties.Conteiners
{
    class InformationContainer<T>
     where T : Information
    {
        public List<T> Informationabout { get; set; }
        public int UnemInfoCount { get; set; }

        public InformationContainer()
        {
            Informationabout = new List<T>();
        }
    }
}
