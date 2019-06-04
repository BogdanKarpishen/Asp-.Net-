using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogDatabase
{
    public class Comments : BaseEntity
    {
        [Required]
        [StringLength(50,MinimumLength=3,ErrorMessage ="Name must be 3 o more simbols")]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
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
