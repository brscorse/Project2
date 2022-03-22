using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Context :DbContext
    {
       public Context (DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Group> Responses { get; set; }
        public DbSet<TimeSlot> Times { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Group>().HasData(

                new Group
                {
                    GroupId = 1,
                    GroupName = "Test Group",
                    GroupSize = "10",
                    Email = "test@test.com",
                    Phone = "8011234567",
                    TimeSlotId = 1
                }
              );

            mb.Entity<TimeSlot>().HasData(
                new TimeSlot
                {
                    TimeSlotId = 1,
                    Date = "04/01/22",
                    Time = "9",
                    Available = true
                }
              );

        }
    }

}


