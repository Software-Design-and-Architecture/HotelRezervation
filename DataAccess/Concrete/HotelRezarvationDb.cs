using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class HotelRezarvationDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0AQV4FJ;Database=HotelRezarvationDB;Trusted_Connection=true");

        }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccommodationTool> AccommodationTools { get; set; }
        public DbSet<TransportVehicle> TransportVehicles { get; set; }
        public DbSet<TransportVehicleType> TransportVehiclesTypes { get; set; }
        public DbSet<AccommodationToolType> AccommodationToolsTypes { get; set; }

    }
}
