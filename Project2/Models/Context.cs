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
        public DbSet<TimeSlot> times { get; set; }

    }

}


