using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_CORE_WEBAPI.Models
{
    public class _no_use_CitiesDataStore
    {
        public static _no_use_CitiesDataStore Current { get; } = new _no_use_CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public _no_use_CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id =1,
                    Name ="New York",
                    Description ="The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "Central Part1",
                            Description = "The most visited urban park in the usa"
                        },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "Central Part2",
                            Description = "The most visited urban park in the usa"
                        }
                    }
                },
                new CityDto()
                {
                    Id =2,
                    Name ="New York2",
                    Description ="The one with that big park2",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "Central Part2222",
                            Description = "The most visited urban park in the usa"
                        },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "Central Part22222",
                            Description = "The most visited urban park in the usa"
                        }
                    }
                },
                new CityDto()
                {
                    Id =3,
                    Name ="New York3",
                    Description ="The one with that big park3",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "Central Part2222",
                            Description = "The most visited urban park in the usa"
                        },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "Central Part22222",
                            Description = "The most visited urban park in the usa"
                        }
                    }
                }
            };
        }

       
    }
}
