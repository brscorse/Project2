using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class TimeSlot
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public Boolean Available { get; set; }
        [Key]
        [Required]
        public long GroupId { get; set; }

    }
}
