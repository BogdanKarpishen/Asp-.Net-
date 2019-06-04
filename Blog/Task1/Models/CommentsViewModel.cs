using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    //TODO IEnumerable
    public class CommentsViewModel
    {
        public string userName { get; set; }
        public string review { get; set; }

        public CommentsViewModel()
        {

        }

        public CommentsViewModel(string userName,string review)
        {
            this.userName = userName;
            this.review = review;
        }
    }
    
}