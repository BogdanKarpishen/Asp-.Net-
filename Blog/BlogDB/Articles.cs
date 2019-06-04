using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BlogDatabase
{
    public class Articles:BaseEntity
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3 o more simbols")]
        public string Name { get; set;}
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "YourName must be 3 o more simbols")]
        public string Creator { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [Required]
        public virtual List<Tag> Tags { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

        public Articles():base()
        {
            Tags = new List<Tag>();
        }

        public Articles(string name, string creator, DateTime dateTime, string text, List<Tag> tags)
        {
            
            this.Name = name;
            this.Creator = creator;
            this.Date = dateTime;
            this.Text = text;
            this.Tags = tags;
        }
    }

    public class Tag: BaseEntity
    {
        public string TagName { get; set; }
        public Tag():base()
        {

        }

        public Tag(string name)
        {
            this.TagName = name;
        }
    }
    
}
