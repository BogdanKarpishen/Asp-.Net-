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
        public string Creator { get; set; }

        public string Text { get; set; }

        public virtual Articles Article { get;set; }
    }
}
