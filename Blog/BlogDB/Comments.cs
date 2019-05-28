using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDatabase
{
    public class Comments : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Review { get; set; }

        public virtual Articles Article { get;set; }

        public Comments() : base()
        { }

        public Comments(string userName, DateTime creationTime, string review)
        {
            this.Name = userName;
            this.CreationDate = creationTime;
            this.Review = review;
        }
    }
}
