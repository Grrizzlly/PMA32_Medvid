using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project
{
    abstract class Unit
    {
        public int Id { get; set; }
        public string requirements { get; set; }
        public string Post { get; set; }
        public Unit() { }
        public Unit(int a,string b, string c)
        {
            a = Id;
            b = Post;
            c = requirements;
        }
    }

    class unemployed:Unit
    {
        public Information Unemployer { get; set; }
        public string profesion { get; set; }
        public string education { get; set; }
        
        public string Previos_place { get; set; }
        public string Whyfired { get; set; }
        public string Contacts { get; set; }
        
        public unemployed() { }
        public unemployed(Information n, string a,string b,string c,string d, string e, string f, string g, int h) :base( h,c,g)
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

    class Jobs:Unit
    {
        public string Firm { get; set; }
        public string working_conditions { get; set; }
        public string payment  { get; set; }
       
        public Jobs() { }
        public Jobs(string a, string b, string c, string d, string e, int h)
            : base(h,b,e)
        { 
            a = Firm;
                b = Post;
                c = working_conditions;
                d = payment;
                e = requirements;
                
        }

    }

    class Information
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Year_of_Birth { get; set; }
        public Information() {}
        public Information(string a, string b,int c)
            
        { 
            a = FirstName;
                b = SurName;
                c = Year_of_Birth;
               
                
        }
    }
}
