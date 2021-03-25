using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFBasics.Models
{
    public class PetsContext : DbContext
    {
        public PetsContext(DbContextOptions<PetsContext> options)
            :base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>().ToTable("Cats");
            modelBuilder.Entity<Dog>().ToTable("Dogs");
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}
