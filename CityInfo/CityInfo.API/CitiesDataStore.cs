using Microsoft.AspNetCore.Mvc.Formatters;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()


        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "City1",
                    Description = "Description1",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "City1Point1",
                            Description = "City1PointDescription1"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "City1Point2",
                            Description = "City1PointDescription2"
                        }

                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "City2",
                    Description = "Description2",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "City2Point1",
                            Description = "City2PointDescription1"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "City2Point2",
                            Description = "City2PointDescription2"
                        }

                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "City3",
                    Description = "Description3",
                     PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "City3Point1",
                            Description = "City3PointDescription1"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "City3Point2",
                            Description = "City3PointDescription2"
                        }

                    }
                },


            };

        }
    }
}
