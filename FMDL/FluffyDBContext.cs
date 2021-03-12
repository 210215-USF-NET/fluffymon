using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FMModels;

namespace FMDL
{
    public class FluffyDBContext : DbContext
    {
        public FluffyDBContext(DbContextOptions options) : base(options)
        {
        }

        protected FluffyDBContext()
        {
        }


        public DbSet<Fluffymon> Fluffymons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFluffymon> UserFluffymons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fluffymon>()
                .Property(Fluffymon => Fluffymon.FluffymonId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .Property(User => User.UserId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserFluffymon>()
                .Property(UserFluffymon => UserFluffymon.UserFluffymonId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserFluffymon>()
                .HasKey(uf => new { uf.FluffymonId, uf.UserId });
        }
    }
}
