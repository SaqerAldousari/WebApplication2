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
        public DbSet<Leader> Leader { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Questions> Question { get; set; }
        public DbSet<Employees> Employee { get; set; }
    }
}
