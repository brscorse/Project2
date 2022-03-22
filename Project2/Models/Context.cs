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

        public DbSet<Group> Groups { get; set; }
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
                },
                new Group
                {
                    GroupId = 2,
                    GroupName = "Test Group",
                    GroupSize = "10",
                    Email = "test@test.com",
                    Phone = "8011234567",
                    TimeSlotId = 2
                }

              );

            mb.Entity<TimeSlot>().HasData(
                new TimeSlot
                {
                    TimeSlotId = 1,
                    Date = "04/01/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 2,
                    Date = "04/01/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 3,
                    Date = "04/01/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 4,
                    Date = "04/01/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 5,
                    Date = "04/01/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 6,
                    Date = "04/01/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 7,
                    Date = "04/01/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 8,
                    Date = "04/01/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 9,
                    Date = "04/01/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 10,
                    Date = "04/01/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 11,
                    Date = "04/01/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 12,
                    Date = "04/01/22",
                    Time = "7 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 13,
                    Date = "04/01/22",
                    Time = "8 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 14,
                    Date = "04/02/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 15,
                    Date = "04/02/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 16,
                    Date = "04/02/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 17,
                    Date = "04/02/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 18,
                    Date = "04/02/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 19,
                    Date = "04/02/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 20,
                    Date = "04/02/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 21,
                    Date = "04/02/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 22,
                    Date = "04/02/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 23,
                    Date = "04/02/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 24,
                    Date = "04/02/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 25,
                    Date = "04/02/22",
                    Time = "7 PM",
                    Available = true
                },


                new TimeSlot
                {
                    TimeSlotId = 26,
                    Date = "04/02/22",
                    Time = "8 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 27,
                    Date = "04/03/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 28,
                    Date = "04/03/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 29,
                    Date = "04/03/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 30,
                    Date = "04/03/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 31,
                    Date = "04/03/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 32,
                    Date = "04/03/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 33,
                    Date = "04/03/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 34,
                    Date = "04/03/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 35,
                    Date = "04/03/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 36,
                    Date = "04/03/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 37,
                    Date = "04/03/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 38,
                    Date = "04/03/22",
                    Time = "7 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 39,
                    Date = "04/03/22",
                    Time = "8 PM",
                    Available = true
                },

                // 4/4
                new TimeSlot
                {
                    TimeSlotId = 40,
                    Date = "04/04/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 41,
                    Date = "04/04/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 42,
                    Date = "04/04/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 43,
                    Date = "04/04/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 44,
                    Date = "04/04/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 45,
                    Date = "04/04/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 46,
                    Date = "04/04/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 47,
                    Date = "04/04/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 48,
                    Date = "04/04/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 49,
                    Date = "04/04/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 50,
                    Date = "04/04/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 51,
                    Date = "04/04/22",
                    Time = "7 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 52,
                    Date = "04/04/22",
                    Time = "8 PM",
                    Available = true
                },

                // 4/5
                new TimeSlot
                {
                    TimeSlotId = 53,
                    Date = "04/05/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 54,
                    Date = "04/05/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 55,
                    Date = "04/05/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 56,
                    Date = "04/05/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 57,
                    Date = "04/05/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 58,
                    Date = "04/05/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 59,
                    Date = "04/05/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 60,
                    Date = "04/05/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 61,
                    Date = "04/05/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 62,
                    Date = "04/05/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 63,
                    Date = "04/05/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 64,
                    Date = "04/05/22",
                    Time = "7 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 65,
                    Date = "04/05/22",
                    Time = "8 PM",
                    Available = true
                },

                // 4/6
                new TimeSlot
                {
                    TimeSlotId = 66,
                    Date = "04/06/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 67,
                    Date = "04/06/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 68,
                    Date = "04/06/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 69,
                    Date = "04/06/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 70,
                    Date = "04/06/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 71,
                    Date = "04/06/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 72,
                    Date = "04/06/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 73,
                    Date = "04/06/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 74,
                    Date = "04/06/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 75,
                    Date = "04/06/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 76,
                    Date = "04/06/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 77,
                    Date = "04/06/22",
                    Time = "7 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 78,
                    Date = "04/06/22",
                    Time = "8 PM",
                    Available = true
                },

                // 4/7
                new TimeSlot
                {
                    TimeSlotId = 79,
                    Date = "04/07/22",
                    Time = "8 AM",
                    Available = true
                },

                new TimeSlot
                {
                    TimeSlotId = 80,
                    Date = "04/07/22",
                    Time = "9 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 81,
                    Date = "04/07/22",
                    Time = "10 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 82,
                    Date = "04/07/22",
                    Time = "11 AM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 83,
                    Date = "04/07/22",
                    Time = "12 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 84,
                    Date = "04/07/22",
                    Time = "1 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 85,
                    Date = "04/07/22",
                    Time = "2 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 86,
                    Date = "04/07/22",
                    Time = "3 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 87,
                    Date = "04/07/22",
                    Time = "4 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 88,
                    Date = "04/07/22",
                    Time = "5 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 89,
                    Date = "04/07/22",
                    Time = "6 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 90,
                    Date = "04/07/22",
                    Time = "7 PM",
                    Available = true
                },
                new TimeSlot
                {
                    TimeSlotId = 91,
                    Date = "04/07/22",
                    Time = "8 PM",
                    Available = true
                }

);

        }
    }

}


