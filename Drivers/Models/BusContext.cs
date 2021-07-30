using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Models
{
    public class BusContext : DbContext
    {
        public BusContext(DbContextOptions<BusContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}
