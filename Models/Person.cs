using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string  FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Link> Links { get; set; }
        public ICollection<PersonInterest> PersonInterests { get; set; }
    }
}
