using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MSACSDegreePlanner.Models;

namespace MSACSDegreePlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Degree>().ToTable("Degrees");
            modelBuilder.Entity<Requirement>().ToTable("Requirements");
            
        }


    }
}






