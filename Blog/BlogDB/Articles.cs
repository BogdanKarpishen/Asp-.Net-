using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDatabase
{
    public class Articles:BaseEntity
    {
        public string Theme { get; set; }
        public string Name { get; set;}
        public string Creator { get; set; }
        public DateTime Date { get; set; }

        public string Text { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

        public Articles():base()
        {
        }

        public Articles(string theme, string name, string creator, DateTime dateTime, string text)
        {
            this.Theme = theme;
            this.Name = name;
            this.Creator = creator;
            this.Date = dateTime;
            this.Text = text;
        }
    }
}
