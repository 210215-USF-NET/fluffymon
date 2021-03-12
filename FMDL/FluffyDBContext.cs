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

            modelBuilder.Entity<Fluffymon>()
                .HasData(
                    new Fluffymon
                    {
                        FluffymonId = 1,
                        FluffymonName = "CommieMon",
                        Fluffiness = 30,
                        AES = 18,
                        MGTR = 10,
                        Element = Element.Yaoi
                    },
                    new Fluffymon
                    {
                        FluffymonId = 2,
                        FluffymonName = "WestonMon",
                        Fluffiness = 20,
                        AES = 50,
                        MGTR = 14,
                        Element = Element.Shonen
                    },
                    new Fluffymon
                    {
                        FluffymonId = 3,
                        FluffymonName = "DoomerMon",
                        Fluffiness = 40,
                        AES = 25,
                        MGTR = 15,
                        Element = Element.Seinen
                    },
                    new Fluffymon
                    {
                        FluffymonId = 4,
                        FluffymonName = "PokeMon",
                        Fluffiness = 20,
                        AES = 30,
                        MGTR = 20,
                        Element = Element.Shojo
                    },
                    new Fluffymon
                    {
                        FluffymonId = 5,
                        FluffymonName = "CommeTankMon",
                        Fluffiness = 50,
                        AES = 30,
                        MGTR = 5,
                        Element = Element.Yuri
                    }
                );
        }
    }
}
