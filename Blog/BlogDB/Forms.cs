using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogDatabase
{
    public class Forms :BaseEntity
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "FirtsName must be 3 o more simbols")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "SecondName must be 3 o more simbols")]
        public string SecondName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public List<string> SecretName { get; set; }
        public List<string> Weapons { get; set; }

        public Forms():base()
        { }

        public Forms(string firstName, string secondName, string city, string[] secretName, string[] weapons)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.City = city;
            this.SecretName = new List<string>(secretName);
            this.Weapons = new List<string>(weapons);

        }
    }
}
