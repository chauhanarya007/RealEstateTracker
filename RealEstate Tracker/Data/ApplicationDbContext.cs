using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
