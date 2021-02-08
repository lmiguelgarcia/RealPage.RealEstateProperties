using Microsoft.EntityFrameworkCore;
using RealPage.RealEstateProperties.Data.Context.Interfaces;
using RealPage.RealEstateProperties.Entity;

namespace RealPage.RealEstateProperties.Data.Context
{
    public class RealStatePropertiesContext : DbContext, IRealStatePropertiesContext
    {
        #region Properties
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        #endregion

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=blogging.db");
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyType>().HasData(
                new PropertyType { PropertyTypeId = 1, Description = "Apartment" },
                new PropertyType { PropertyTypeId = 2, Description = "House" }
            );
        }

        #endregion
    }
}