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
        //declare to EF Core that these are the models I want to be persisted to my db


       // public DbSet<Element>

    }
}
