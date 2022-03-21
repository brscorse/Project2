using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Group
    {
        [Key]
        [Required]
        public long BookId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(0, 15)]
        public string GroupSize { get; set; }
        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; }
        public string Phone { get; set; }



    }
}
