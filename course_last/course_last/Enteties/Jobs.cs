using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_last.Enteties
{
  public abstract class Jobs
    {
        public string Firm { get; set; }
        public string working_conditions { get; set; }
        public string payment { get; set; }
        public string requirements { get; set; }
        public string Post { get; set; }
        public Jobs() { }
        public Jobs(string a, string b, string c, string d, string e)
        {
            a = Firm;
            b = Post;
            c = working_conditions;
            d = payment;
            e = requirements;

        }
    }
  public class Full_employment : Jobs
   {
       public uint hours_per_day { get; set; }
       public Full_employment() { }
       public Full_employment(string a, string b, string c, string d, string e, uint n)
           : base(a, c, d, b, e)
       {
           a = Firm;
           b = Post;
           c = working_conditions;
           d = payment;
           e = requirements;
           n = hours_per_day;
       }
   }
  public class underemployment : Jobs
   {
       public uint hours_per_day { get; set; }
       public bool Home_work { get; set; }
       public underemployment() { }
       public underemployment(string a, string b, string c, string d, string e, uint n, bool v)
           : base(a, c, d, b, e)
       {
           a = Firm;
           b = Post;
           c = working_conditions;
           d = payment;
           e = requirements;
           n = hours_per_day;
           v = Home_work;
       }
   }
}
