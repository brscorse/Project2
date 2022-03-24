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
        //[Required(ErrorMessage = "group id error")]
        public long GroupId { get; set; }
        [Required(ErrorMessage = "Please enter the group name")]
        public string GroupName { get; set; }

        [Required(ErrorMessage = "Please enter the group size")]
        [Range(0, 15)]
        public int GroupSize { get; set; }

        [Required(ErrorMessage = "Please enter the Email address")]
        [EmailAddress]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Please enter the phone number")]
        public string Phone { get; set; }


        // FK relationship
        //[Required(ErrorMessage = "time slot id error")]
        public int TimeSlotId { get; set; }
        public TimeSlot TimeSlot { get; set; }



    }
}
