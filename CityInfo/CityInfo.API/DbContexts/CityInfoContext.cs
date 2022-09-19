using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("City1")
                {
                    Id = 1,
                    Description = "Description1"
                },

                new City("City2")
                {
                    Id = 2,
                    Description = "Description2"
                },

                new City("City3")
                {
                    Id = 3,
                    Description = "Description3"
                }
                );
            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("City1Point1")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "City1PointDescription1"
                },

                 new PointOfInterest("City1Point2")
                 {
                     Id = 2,
                     CityId = 1,
                     Description = "City1PointDescription2"
                 },

                  new PointOfInterest("City2Point1")
                  {
                      Id = 3,
                      CityId = 2,
                      Description = "City2PointDescription1"
                  },

                   new PointOfInterest("City2Point2")
                   {
                       Id = 4,
                       CityId = 2,
                       Description = "City2PointDescription2"
                   },

                    new PointOfInterest("City3Point1")
                    {
                        Id = 5,
                        CityId = 3,
                        Description = "City3PointDescription1"
                    },

                     new PointOfInterest("City3Point2")
                     {
                         Id = 6,
                         CityId = 3,
                         Description = "City3PointDescription2"
                     }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
