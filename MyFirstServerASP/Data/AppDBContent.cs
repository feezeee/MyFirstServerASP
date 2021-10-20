using Microsoft.EntityFrameworkCore;
using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent (DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Worker> Worker { get; set; }

        public DbSet<Position> Position { get; set; }
    }
}
