using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties
{
   public class unemployed
    {
        public Information Unemployer { get; set; }
        public string profesion { get; set; }
        public string education { get; set; }
        public string requirements { get; set; }
        public string Post { get; set; }
        public string Previos_place { get; set; }
        public string Whyfired { get; set; }
        public string Contacts { get; set; }

        public unemployed() { }
        public unemployed(Information n, string a, string b, string c, string d, string e, string f, string g)
        {
            a = profesion;
            b = education;
            c = Post;
            d = Previos_place;
            e = Whyfired;
            f = Contacts;
            g = requirements;
            n = Unemployer;
        }
    }
}
