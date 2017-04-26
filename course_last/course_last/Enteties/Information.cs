using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties
{
  public  class Information
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Year_of_Birth { get; set; }
        public Information() { }
        public Information(string a, string b, int c)
        {
            a = FirstName;
            b = SurName;
            c = Year_of_Birth;


        }
    }
}
