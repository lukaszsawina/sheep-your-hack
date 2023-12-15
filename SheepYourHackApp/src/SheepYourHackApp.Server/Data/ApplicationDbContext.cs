using Microsoft.EntityFrameworkCore;
using SheepYourHackApp.Server.Models;
using System;

namespace SheepYourHackApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<TestModel> test { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestModel>().HasData(
                new TestModel()
                {
                    Id = 1,
                    Name = "Test"
                }
                );
        }
    }
}
