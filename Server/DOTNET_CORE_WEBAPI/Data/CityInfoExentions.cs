using DOTNET_CORE_WEBAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_CORE_WEBAPI.Data
{
    public static class CityInfoExentions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if(context.Cities.Any())
            {
                return;
            }

            //init seed data
            var cities = new List<City>()
            {
                new City() {
                    Name="New York City",
                    Description ="new york bridge tour",
                    Info ="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Tenetur, nam omnis error corrupti eum assumenda enim odit architecto corporis. Sequi",
                    ImagePath = "http://localhost:1562/images/london.jpeg",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name ="Central Park",
                            Description = "The most visited urban park in the USA"
                        },
                        new PointOfInterest()
                        {
                            Name ="Empire State Building",
                            Description = "The second visited urban park in the USA"
                        }
                    }
                },
                new City() {
                    Name="London",
                    Description ="The one with that big park",
                    Info ="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Tenetur, nam omnis error corrupti eum assumenda enim odit architecto corporis. Sequi",
                    ImagePath = "http://localhost:1562/images/newyork.jpeg",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name ="1Central Park",
                            Description = "The most visited urban park in the USA"
                        },
                        new PointOfInterest()
                        {
                            Name ="1Empire State Building",
                            Description = "The second visited urban park in the USA"
                        }
                    }
                },
                new City() {
                    Name="Paris",
                    Description ="The one with that big park",
                    Info ="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Tenetur, nam omnis error corrupti eum assumenda enim odit architecto corporis. Sequi",
                    ImagePath = "http://localhost:1562/images/paris.jpeg",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name ="2Central Park",
                            Description = "The most visited urban park in the USA"
                        },
                        new PointOfInterest()
                        {
                            Name ="2Empire State Building",
                            Description = "The second visited urban park in the USA"
                        }
                    }
                },
                new City() {
                    Name="Tokyo",
                    Description ="The one with that big park",
                    Info ="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Tenetur, nam omnis error corrupti eum assumenda enim odit architecto corporis. Sequi",
                    ImagePath = "http://localhost:1562/images/tokyo.jpeg",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name ="3Central Park",
                            Description = "The most visited urban park in the USA"
                        },
                        new PointOfInterest()
                        {
                            Name ="3Empire State Building",
                            Description = "The second visited urban park in the USA"
                        }
                    }
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
