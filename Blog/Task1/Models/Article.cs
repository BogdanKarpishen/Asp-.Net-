using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogDatabase;

namespace Task1.Models
{
    public class Article: BlogDbContextInitializer
    {
        BlogDBContext blog = new BlogDBContext();
        public string Theme { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public DateTime Date { get; set; }

        public string Text { get; set; }
        
        public Article(string theme, string name,string creator,DateTime dateTime,string Text)
        {
        
        }
        
    }
}