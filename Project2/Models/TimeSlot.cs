using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class TimeSlot
    {
        [Key]
        [Required(ErrorMessage = "Time ID Error")]
        public int TimeSlotId { get; set; }
        [Required(ErrorMessage = "Date isn't filled")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Time isn't filled")]
        public string Time { get; set; }
        [Required(ErrorMessage = "Availability error")]
        public bool Available { get; set; }

    }
}
