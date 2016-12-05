using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMainProject
{
    class MainClass
    {

    }
    class unemployed
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

    abstract class Jobs
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

    class Full_employment : Jobs
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
    class underemployment : Jobs
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
    class Information
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
