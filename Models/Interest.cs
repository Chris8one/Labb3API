using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string InterestTitle { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string InterestDescription { get; set; }

        public ICollection<Link> Links { get; set; }
        public ICollection<PersonInterest> PersonInterests { get; set; }
    }
}
