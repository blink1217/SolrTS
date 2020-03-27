using Microsoft.EntityFrameworkCore;
using SolrTS.Models;
using System;

namespace SolrTS.Database
{
    public class SolrContext : DbContext
    {
        public SolrContext(DbContextOptions<SolrContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = "PX1",
                    Name = "Kevin",
                    Group = "Blue",
                    JoinDate = DateTime.Now.AddDays(-1)
                },
                new Person
                {
                    Id = "PX2",
                    Name = "Chris",
                    Group = "Blue",
                    JoinDate = DateTime.Now.AddDays(-2)
                },
                new Person
                {
                    Id = "PX3",
                    Name = "Claire",
                    Group = "Red",
                    JoinDate = DateTime.Now.AddDays(-3)
                },
                new Person
                {
                    Id = "PX4",
                    Name = "Sophie",
                    Group = "Blue",
                    JoinDate = DateTime.Now.AddDays(-4)
                },
                new Person
                {
                    Id = "PX5",
                    Name = "Katalin",
                    Group = "Red",
                    JoinDate = DateTime.Now.AddDays(-5)
                }
            );
        }
    }
}
