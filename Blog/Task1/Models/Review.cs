using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    //TODO IEnumerable
    public class Review
    {
        public string userName { get; set; }
        public string creationTime { get; set; }
        public string review { get; set; }

        public Review(string userName,string dateTime,string review)
        {
            this.userName = userName;
            this.creationTime = dateTime;
            this.review = review;
        }
    }
    
}