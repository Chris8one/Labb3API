using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }
        public string LinkDescription { get; set; }
        public string LinkUrl { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
