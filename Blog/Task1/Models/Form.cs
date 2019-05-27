using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Form
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string city {get;set;}
        public string[] secretName { get; set; }
        public string[] weapons { get; set; }

        public Form(string firstName, string secondName,string city, string[] secretName, string[] weapons)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.city = city;
            this.secretName = secretName;
            this.weapons = weapons;

        }   
    }
}