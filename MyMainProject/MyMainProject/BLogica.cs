using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMainProject
{
    class BLogica
    {
        public unemployed Addump(Information Info, string prof,  string Educ,  string require, string Pos, string Prev_p, string Whyf, string Cont)
        {
            unemployed port = new unemployed();
            port.Unemployer = Info;
            port.education = Educ;
            port.profesion = prof;
            port.requirements = require;
            port.Whyfired = Whyf;
            port.Post = Pos;
            port.Previos_place = Prev_p;

            return port;
        }
        public Full_employment AddFull_emp(string Fi, string Po, string Wo, string pay, string req, uint hou )
        {
            Full_employment port = new Full_employment();
            port.Firm = Fi ;
            port.Post = Po;
            port.working_conditions = Wo;
            port.payment = pay;
            port.requirements = req;
            port.hours_per_day = hou;
            return port;
        }
        public underemployment AddFull_emp(string Fi, string Po, string Wo, string pay, string req, uint hou, bool Hom)
        {
            underemployment port = new underemployment();
            port.Firm = Fi;
            port.Post = Po;
            port.working_conditions = Wo;
            port.payment = pay;
            port.requirements = req;
            port.hours_per_day = hou;
            port.Home_work = Hom;
            return port;
        }
        public unemployed Changeump(unemployed port, Information Info, string prof, string Educ, string require, string Pos, string Prev_p, string Whyf, string Cont)
        {
            
            port.Unemployer = Info;
            port.education = Educ;
            port.profesion = prof;
            port.requirements = require;
            port.Whyfired = Whyf;
            port.Post = Pos;
            port.Previos_place = Prev_p;

            return port;
        }
        public Full_employment changeFull_emp(Full_employment port, string Fi, string Po, string Wo, string pay, string req, uint hou)
        {
            
            port.Firm = Fi;
            port.Post = Po;
            port.working_conditions = Wo;
            port.payment = pay;
            port.requirements = req;
            port.hours_per_day = hou;
            return port;
        }
        public underemployment Changeunderemp(underemployment port, string Fi, string Po, string Wo, string pay, string req, uint hou, bool Hom)
        {
            
            port.Firm = Fi;
            port.Post = Po;
            port.working_conditions = Wo;
            port.payment = pay;
            port.requirements = req;
            port.hours_per_day = hou;
            port.Home_work = Hom;
            return port;
        }
        
    }
}
