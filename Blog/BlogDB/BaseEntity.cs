using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogDatabase
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public BaseEntity()
        { }
    }
}
