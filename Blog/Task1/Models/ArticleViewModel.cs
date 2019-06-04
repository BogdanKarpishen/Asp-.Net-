using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogDatabase;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class ArticleViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3 o more simbols")]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "YourName must be 3 o more simbols")]
        public string Creator { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        
        public List<Tag> Tags { get; set; }

        public ArticleViewModel(string name,DateTime date, string creator,string text, List<Tag> tags)
        {
            
            this.Name = name;
            this.CreationDate = date;
            this.Creator = creator;
            this.Text = text;
            this.Tags = tags;
        }

    }
}