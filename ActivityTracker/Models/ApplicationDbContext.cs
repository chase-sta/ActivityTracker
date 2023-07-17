using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ActivityTracker.Models;

namespace ActivityTracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Activities.sqlite");
        }

        public DbSet<Activityt> Activities { get; set; }
    }

}
