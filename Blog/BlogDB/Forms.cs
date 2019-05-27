using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDatabase
{
    public class Forms :BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string City { get; set; }
        public string[] SecretName { get; set; }
        public string[] Weapons { get; set; }
    }
}
