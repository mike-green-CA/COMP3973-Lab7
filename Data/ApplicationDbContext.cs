using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP3973_lab4_A01045801_Michael_Green.Data;
using COMP3973_lab4_A01045801_Michael_Green.Models;

namespace COMP3973_lab4_A01045801_Michael_Green.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<City>().HasData(SampleData.GetCities());
            modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
        }

        public DbSet<Province> Provinces {get; set;}
        public DbSet<City> Cities {get; set;}
    }
}
