using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Leader> Leaders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
